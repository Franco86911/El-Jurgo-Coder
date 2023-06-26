using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Key : MonoBehaviour
{
    //private bool k_get = false;
    public Action<bool> OnKeyGet;

    public void Interact()
    {
        OnKeyGet?.Invoke(true);
    }
}
