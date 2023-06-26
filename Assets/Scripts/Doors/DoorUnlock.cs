using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorUnlock : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] protected Key m_key;
  
    private void Awake()
    {
        door.SetActive(false);
        m_key.OnKeyGet += Unlock;
    }

    private void Unlock(bool h_key)
    {
        door.SetActive(true);
    }
}
