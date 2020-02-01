using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyConsumer : CustomYieldInstruction
{
    public override bool keepWaiting
    {
        get
        {
            return false;
        }
    }

    public KeyConsumer(float timer, InputAction action)
    {

    }
}
