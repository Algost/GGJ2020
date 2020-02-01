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

    bool damaged { get; }

    void StartRepair();
    void RepairFail();
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

    public UnityEvent onStartRepair;
    public UnityEvent onRepairSuccess;
    public UnityEvent onRepairFail;

    public UnityEvent onFinishRepair;
    [SerializeField]
    private int m_repairCount;
    [SerializeField]
    private float m_actionTime;
    [SerializeField]
    private bool m_damaged;

    public int repairActionsCount => m_repairCount;

    InputActionMap IRepairable.possibleActions => m_possibleActions;

    public float actionTime => m_actionTime;

    public bool damaged => m_damaged;

    private void Start()
    {
        InitActions();
        onOverHeat.AddListener(OnOverHeat);
        onOverHeat?.Invoke();
    }

    private void OnOverHeat()
    {
        m_damaged = true;
    }

    private InputAction GetRandomAction()
    {
        var actions = m_possibleActions.actions;
        return actions[Random.Range(0, actions.Count)];
    }

    public void StartRepair()
    {
        onStartRepair?.Invoke();
    }

    public InputAction GetNextAction()
    {
        print(m_repairActionsQueue.Count);
        if (m_repairActionsQueue.Count == 0) return null;
        return m_repairActionsQueue.Dequeue();
    }

    public void FinishRepair()
    {
        onFinishRepair?.Invoke();
    }

    public void RepairFail()
    {
        onRepairFail?.Invoke();
    }

    public void SuccessRepair()
    {
        m_damaged = false;
        onRepairSuccess?.Invoke();
    }

    public void CreateNewAction()
    {
        m_repairActionsQueue.Enqueue(GetRandomAction());
    }

    public void InitActions()
    {
        m_repairActionsQueue.Clear();
        for (int i = 0; i < repairActionsCount; i++)
        {
            m_repairActionsQueue.Enqueue(GetRandomAction());
        }
    }
}
