using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Repairer : MonoBehaviour
{
    private bool playerInput = false;

    private InputAction m_expectedAction;
    private InputAction m_playerAction;
    private IRepairable m_repairable;
    private bool m_repairing = false;

    public void StartRepair(IRepairable repairable)
    {
        StartCoroutine("TryRepair", repairable);
    }

    int counter = 0;
    private void CheckAction(InputAction.CallbackContext obj)
    {
        int count = m_repairable.possibleActions.actions.Count;
        int tmp = (counter++) % count;
        if (tmp == 0)
        {
            m_playerAction = obj.action;
            playerInput = true;
        }
    }

    IEnumerator TryRepair(IRepairable repairable)
    {
        print("toto");
        m_repairing = true;
        PlayerInput playerInputs = GetComponent<PlayerInput>();
        //if (playerInputs.actions.actionMaps.Count > 0)
        //{
        //    playerInputs.actions.actionMaps[1].Disable();
        //}
        try
        {
            playerInputs.actions.AddActionMap(repairable.possibleActions);
        }
        catch (Exception)
        {
            playerInputs.actions.actionMaps[1].Disable();
            playerInputs.actions.RemoveActionMap("Possible Actions");
            playerInputs.actions.AddActionMap(repairable.possibleActions);
        }
        InputActionMap actions = playerInputs.actions.actionMaps.Last();
        actions.Enable();
        m_expectedAction = repairable.GetNextAction();
        repairable.SetImage(GetPlayerType(playerInputs), m_expectedAction);
        actions.actionTriggered += context => CheckAction(context);

        bool finished = false;
        playerInput = false;
        while (!finished)
        {
            float timeout = 0;
            while (timeout < repairable.actionTime)
            {
                yield return 0;
                timeout += Time.deltaTime;
                if (playerInput)
                {
                    playerInput = false;
                    timeout = 0;
                    if (m_playerAction == m_expectedAction)
                    {
                        if (OnExpectedSuccess(repairable, playerInputs))
                        {
                            finished = true;
                            break;
                        }
                    }
                    else
                    {
                        OnExpectedFail(repairable, playerInputs);
                    }
                }
            }
            if (!finished)
                OnExpectedFail(repairable, playerInputs);
        }
        actions.Disable();
        actions.actionTriggered -= CheckAction;
        playerInputs.actions.RemoveActionMap(repairable.possibleActions);
        m_repairing = false;
    }

    private int GetPlayerType(PlayerInput player)
    {
        foreach (var item in player.devices)
        {
            print(item.name);
        }
        return 0;
    }

    void OnExpectedFail(IRepairable repairable, PlayerInput playerInputs)
    {
        repairable.CreateNewAction();
        m_expectedAction = repairable.GetNextAction();
        repairable.SetImage(GetPlayerType(playerInputs), m_expectedAction);
        repairable.RepairFail();
    }

    bool OnExpectedSuccess(IRepairable repairable, PlayerInput playerInputs)
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
            repairable.SetImage(GetPlayerType(playerInputs), m_expectedAction);
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
}
