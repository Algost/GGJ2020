using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Repairer : MonoBehaviour
{
    private InputAction m_expectedAction;
    private InputAction m_playerAction;
    private IRepairable m_repairable;
    private bool m_repairing = false;

    private PlayerInput m_playerInputs;
    private InputActionMap m_actionMap;
    public string PlayerMaps { get { return string.Format("RuntimeMaps_{0}", m_playerInputs.user.id); } }
    private void Start()
    {
        m_playerInputs = GetComponent<PlayerInput>();
        m_playerAction = null;
    }

    public void StartRepair(IRepairable repairable)
    {
        StartCoroutine("TryRepair", repairable);
    }

    private void CheckAction(InputAction.CallbackContext obj)
    {
        if (obj.phase == InputActionPhase.Started && obj.action.activeControl.device == m_playerInputs.devices[0])
        {
            m_playerAction = obj.action;
        }
    }

    void EnableInputActionMap(InputActionMap inputActions)
    {
        //InputActionMap test = inputActions.Clone();
        m_actionMap = new InputActionMap(PlayerMaps);
        foreach (var action in inputActions.actions)
        {
            InputAction ia = m_actionMap.AddAction(action.name, action.type, null, action.interactions);
            foreach (var bind in action.bindings)
            {
                ia.AddBinding(bind);
            }
        }
        m_actionMap.Enable();
        m_playerInputs.actions.AddActionMap(m_actionMap);
        m_actionMap.actionTriggered += context => CheckAction(context);
    }

    void DisableInputActionMap()
    {
        m_actionMap.Disable();
        m_playerInputs.actions.RemoveActionMap(m_actionMap);
        m_actionMap.Dispose();
    }

    IEnumerator TryRepair(IRepairable repairable)
    {
        m_repairing = true;
        EnableInputActionMap(repairable.possibleActions);
        m_expectedAction = repairable.GetNextAction();
        repairable.SetImage(GetPlayerType(), m_expectedAction);

        bool finished = false;
        while (!finished)
        {
            float timeout = 0;
            while (timeout < repairable.actionTime)
            {
                yield return 0;
                timeout += Time.deltaTime;
                if (m_playerAction != null)
                {
                    timeout = 0;
                    if (m_playerAction.name == m_expectedAction.name)
                    {
                        if (OnExpectedSuccess(repairable))
                        {
                            finished = true;
                            break;
                        }
                    }
                    else
                    {
                        OnExpectedFail(repairable);
                    }
                    m_playerAction = null;
                }
            }
            if (!finished)
                OnExpectedFail(repairable);
        }
        DisableInputActionMap();
        m_repairing = false;
    }

    private int GetPlayerType()
    {
        foreach (var item in m_playerInputs.devices)
        {
            if (item.wasUpdatedThisFrame)
            {
                if (item.description.interfaceName == "XInput")
                {
                    return 0;
                }
                else if (item.description.interfaceName == "HID")
                {
                    return 1;
                }
                else// if (item.description.deviceClass == "Keyboard")
                {
                    return 2;
                }
            }
        }
        return 0;
    }

    void OnExpectedFail(IRepairable repairable)
    {
        repairable.CreateNewAction();
        m_expectedAction = repairable.GetNextAction();
        repairable.SetImage(GetPlayerType(), m_expectedAction);
        repairable.RepairFail();
    }

    bool OnExpectedSuccess(IRepairable repairable)
    {
        m_expectedAction = repairable.GetNextAction();
        repairable.SuccessRepair();
        if (m_expectedAction == null)
        {
            repairable.InitActions();
            repairable.FinishRepair();
            return true;
        }
        else
            repairable.SetImage(GetPlayerType(), m_expectedAction);
        return false;
    }

    private void OnRepair(InputValue value)
    {
        if (!m_repairing && m_repairable != null && m_repairable.damaged)
            StartRepair(m_repairable);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Repairable"))
        {
            m_repairable = collider.GetComponentInParent<IRepairable>();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Repairable"))
        {
            m_repairable = null;
        }
    }

    private void OnDisable()
    {
        m_actionMap.Disable();
        m_playerInputs.actions.RemoveActionMap(m_actionMap);
    }
}
