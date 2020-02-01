using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public interface IRepairable
{
    int repairActionsCount { get; }
    void StartRepair();
    InputAction GetNextAction();
    void FinishRepair();
}

public class Repairable : MonoBehaviour, IRepairable
{
    private Queue<InputAction> m_repairActionsQueue = new Queue<InputAction>();
    [SerializeField]
    private InputActionMap m_possibleActions;

    public UnityEvent onOverHeat;

    public UnityEvent onRepair;

    public UnityEvent onFinishRepair;
    [SerializeField]
    private int m_repairCount;

    public int repairActionsCount => m_repairCount;

    private void InitActions()
    {
        m_repairActionsQueue.Clear();
        for (int i = 0; i < repairActionsCount; i++)
        {
            m_repairActionsQueue.Enqueue(GetRandomAction());
        }
    }

    private void Start()
    {
        onOverHeat.Invoke();
    }

    private InputAction GetRandomAction()
    {
        var actions = m_possibleActions.actions;
        return actions[Random.Range(0, actions.Count)];
    }

    public void StartRepair()
    {
        onRepair.Invoke();
    }

    public InputAction GetNextAction()
    {
        m_repairActionsQueue.Enqueue(GetRandomAction());
        return m_repairActionsQueue.Dequeue();
    }

    public void FinishRepair()
    {
        onFinishRepair.Invoke();
    }
}
