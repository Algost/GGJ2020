using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

public class Repairer : MonoBehaviour
{
    private bool playerInput = false;

    private InputAction m_expectedAction;
    private InputAction m_playerAction;

    public void StartRepair(IRepairable repairable)
    {
        StartCoroutine("TryRepair", repairable);
    }

    private void CheckAction(InputAction.CallbackContext obj)
    {
        m_playerAction = obj.action;
    }

    IEnumerator TryRepair(IRepairable repairable)
    {
        PlayerInput playerInputs = GetComponent<PlayerInput>();
        playerInputs.actions.AddActionMap(repairable.possibleActions);
        InputActionMap actions = playerInputs.actions.actionMaps.Last();
        actions.actionTriggered += CheckAction;

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
                }
            }
            if (!finished)
                OnExpectedFail(repairable);
        }
        actions.actionTriggered -= CheckAction;
        playerInput.actions.RemoveActionMap(repairable.possibleActions);
    }

    void OnExpectedFail(IRepairable repairable)
    {
        repairable.CreateNewAction();
        m_expectedAction = repairable.GetNextAction();
        repairable.FailRepair();
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
        return false;
    }
}
