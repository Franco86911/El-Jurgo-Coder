using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Monster : MonoBehaviour
{
    [SerializeField] private Animator m_animator;
    private bool isTriggered,isTouching;
    private bool f_time = true;
    [SerializeField] private Transform m_target;
    [SerializeField] private float e_distanceToChase = 20;
    [SerializeField] private float e_speedRotation;
    private float e_nearLimit = 2;
    [SerializeField] private AudioSource hit;
    [SerializeField] private AudioClip effect;

    void Update()
    {
        Look();       
        Hit();  
    }

    private void Look()
    {
        var l_diffVector = m_target.position - transform.position;
        if (e_distanceToChase > l_diffVector.magnitude)
        {
            isTriggered = true;
            m_animator.SetBool("Triggered", isTriggered);
            Quaternion newRotation = Quaternion.LookRotation(l_diffVector.normalized);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, e_speedRotation * Time.deltaTime);
        }
    }

    private void Hit()
    {
        
        var t_diffVector = m_target.position - transform.position;
        if(e_nearLimit > t_diffVector.magnitude && f_time)
        {
            isTouching = true;
            m_animator.SetBool("PlayerTouch", isTouching);
            hit.PlayOneShot(effect,1f);
            f_time = false;
        }
    }
}