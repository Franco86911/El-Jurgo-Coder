using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class PassKey : MonoBehaviour
{
    public bool dentro = false;
    [SerializeField] private Renderer rend;
   

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && dentro)
        {
            DoorUnlock.k_get = true;
            rend.enabled = false;
            
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            dentro = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            dentro = false;
        }
    }
}