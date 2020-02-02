using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;

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

    void SetOverHeat();
    InputAction GetNextAction();
    void CreateNewAction();
    void InitActions();

    void SetImage(int type, InputAction action);
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
    public Image ContentImage;

    public UnityEvent onFinishRepair;
    [SerializeField]
    private int m_repairCount;
    [SerializeField]
    private float m_actionTime;
    [SerializeField]
    private bool m_damaged;

    public ActionImage[] actionImages;

    [System.Serializable]
    public class ActionImage
    {
        public Sprite xboxSprite;
        public Sprite ps4Sprite;
        public Sprite keyboardSprite;
        public string action;
    }


    public int repairActionsCount => m_repairCount;

    InputActionMap IRepairable.possibleActions => m_possibleActions;

    public float actionTime => m_actionTime;

    public bool damaged => m_damaged;

    private void Start()
    {
        InitActions();
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
        if (m_repairActionsQueue.Count == 0) return null;
        return m_repairActionsQueue.Dequeue();
    }

    public void FinishRepair()
    {
        m_damaged = false;
        onFinishRepair?.Invoke();
    }

    public void RepairFail()
    {
        onRepairFail?.Invoke();
    }

    public void SuccessRepair()
    {
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

    public void SetOverHeat()
    {
        m_damaged = true;
        onOverHeat?.Invoke();
    }

    public void SetImage(int type, InputAction action)
    {
        foreach (var sa in actionImages)
        {
            if (sa.action == action.name)
            {
                if (type == 0)
                    ContentImage.sprite = sa.xboxSprite;
                else if (type == 1)
                    ContentImage.sprite = sa.ps4Sprite;
                else
                    ContentImage.sprite = sa.keyboardSprite;
            }
        }
    }
}
