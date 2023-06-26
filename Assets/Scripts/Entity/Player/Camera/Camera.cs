using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;
    [SerializeField] private Transform orientation;
    private float xRotation;
    private float yRotation;
    [SerializeField] private CinemachineVirtualCamera d_camera;
    [SerializeField] private float c_Rotation;
    //[SerializeField] private GameObject enemy;
    //private bool dead,las;
    //[SerializeField] private Chase enemyTouch;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        //var m_random = 
        //var l_diffVector = enemy.transform.position - transform.position;
        //if (!dead)
        //{
            var mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensY;
            var mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;

            yRotation += mouseX;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, yRotation, 0);

            //if (!(l_diffVector.magnitude > enemyTouch.m_data.e_nearLimit))
            //{
            //    dead = true;
            //}
        //}
        //else
        //{
        //    Quaternion newRotation = Quaternion.LookRotation(l_diffVector.normalized);
        //    transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, c_Rotation * Time.deltaTime);
        //}
    }
}
