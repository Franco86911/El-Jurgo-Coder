using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator d_anim;
    [SerializeField] private Doors m_button;
    private static readonly int Open = Animator.StringToHash("Open");
    [SerializeField] private AudioSource d_sound;

    private void Awake()
    {
        //m_button.OnPressButton.AddListener(OpenDoor);
        //m_button.OnUnpressButton.AddListener(CloseDoor);
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
