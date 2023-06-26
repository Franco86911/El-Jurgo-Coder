using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLockedController : MonoBehaviour
{
    [SerializeField] private Animator d_anim;
    private static readonly int Locked = Animator.StringToHash("Locked");
    [SerializeField] private AudioSource d_sound;
    private float cont = 2;

    private void Update()
    {
        cont = cont - Time.deltaTime;
        if (cont < 0)
        {
            d_anim.SetBool(Locked, false);
            cont = 2;
        }
    }

    public void LockDoor()
    {
        d_anim.SetBool(Locked, true);
        d_sound.Play();
    }
}
