using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrap : MonoBehaviour
{
    [SerializeField] private AudioSource d_sound;

    private void OnTriggerEnter(Collider col)
    {
        d_sound.Play();
    }
}
