using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anteroom_trap : MonoBehaviour
{
    [SerializeField] private Animator Anim;
    [SerializeField] private Animator Anim2;
    [SerializeField] private Animator Anim3;
    private static readonly int Spin = Animator.StringToHash("Spin");
    [SerializeField] private AudioSource d_sound;
    private bool f_time = true;

    private void OnTriggerEnter(Collider trap)
    {
        Anim.SetBool(Spin, true);
        Anim2.SetBool(Spin, true);
        Anim3.SetBool(Spin, true);
        if (f_time)
        {
            d_sound.Play();
            f_time = false;
        }
    }
}
