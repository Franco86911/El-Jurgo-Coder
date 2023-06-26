using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Movement : MonoBehaviour
{
    [SerializeField] private Animator n_animator;
    [SerializeField] private float n_speed = 2;
    private bool running;
    

    void Update()
    {
        var l_horizontal = Input.GetAxis("Horizontal");
        var l_vertical = Input.GetAxis("Vertical");
        var l_movementDir = new Vector3(l_horizontal, 0, l_vertical);
        l_movementDir.Normalize();
        var l_movementSpeed = (float)(l_movementDir.magnitude * n_speed);
        n_animator.SetFloat("Velocity", l_movementSpeed);
        if (Input.GetKey("left shift"))
        {
            running = true;
            
        }
        else
        {
            running = false;
        }
        n_animator.SetBool("Run", running);
    }
}
