using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public interface IRepairable
{
    int repairActionsCount { get; }
    InputActionMap possibleActions { get; }
    float actionTime { get; }

    void StartRepair();
    void FailRepair();
    void SuccessRepair();
    void FinishRepair();

    InputAction GetNextAction();
    void CreateNewAction();

    void InitActions();
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
    [SerializeField]
    private float m_actionTime;

    public int repairActionsCount => m_repairCount;

    InputActionMap IRepairable.possibleActions => m_possibleActions;

    public float actionTime => m_actionTime;

    private void Start()
    {
        InitActions();
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
        if (m_repairActionsQueue.Count == 0) return null;
        return m_repairActionsQueue.Dequeue();
    }

    public void FinishRepair()
    {
        onFinishRepair.Invoke();
    }

    public void FailRepair()
    {
        throw new System.NotImplementedException();
    }

    public void SuccessRepair()
    {
        throw new System.NotImplementedException();
    }

    public void CreateNewAction()
    {
        m_repairActionsQueue.Enqueue(GetRandomAction());
    }

    void InitActions()
    {
        m_repairActionsQueue.Clear();
        for (int i = 0; i < repairActionsCount; i++)
        {
            m_repairActionsQueue.Enqueue(GetRandomAction());
        }
    }
}
