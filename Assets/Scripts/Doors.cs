using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Doors : MonoBehaviour
{
    public UnityEvent OnPressButton;
    public UnityEvent OnUnpressButton;
    
    
    

    public void PressButton()
    {
        OnPressButton?.Invoke();
    }

    public void UnpressButton()
    {
        OnUnpressButton?.Invoke();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PressButton();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            UnpressButton();
        }
    }
}
