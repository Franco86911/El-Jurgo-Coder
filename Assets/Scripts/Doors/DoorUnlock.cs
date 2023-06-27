using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorUnlock : MonoBehaviour
{
    public static bool k_get = false;
    private bool door;
    public bool dentro = false;
    [SerializeField] private Animator d_anim;
    //[SerializeField] private Doors m_button;
    private static readonly int Open = Animator.StringToHash("Open");
    [SerializeField] private AudioSource d_sound;

    void Update()
    {
        if (dentro && Input.GetKeyDown(KeyCode.E) && k_get)
        {
            door = !door;
            k_get = false;
        }
        if (door)
        {
            OpenDoor();
           
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
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

    public void OpenDoor()
    {
        d_anim.SetBool(Open, true);
        d_sound.Play();
    }

    public void CloseDoor()
    {
        d_anim.SetBool(Open, false);
        d_sound.Play();
    }
}
