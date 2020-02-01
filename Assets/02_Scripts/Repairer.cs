using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

public class Repairer : MonoBehaviour
{
    public void StartRepair(IRepairable repairable)
    {
        AsyncRepair(repairable).WrapErrors();
    }

    async Task AsyncRepair(IRepairable repairable)
    {
        repairable.StartRepair();
        int repairCount = repairable.repairActionsCount;
        for (int i = 0; i < repairCount; i++)
        {
            //await 
        }
    }
}

public static class ExtentionUtils
{
    public static async void WrapErrors(this Task task)
    {
        await task;
    }
}