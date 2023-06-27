using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalText : MonoBehaviour
{
    [SerializeField] private Animator d_anim;

    private void OnTriggerEnter(Collider col)
    {
        d_anim.SetBool("Final", true);
    }
}
