using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : Entity
{
    [SerializeField] private AudioSource run;
    [SerializeField] private GameObject p_light;
    private bool f_off = true;
    private float l_vertical;
    private float l_horizontal;
    [SerializeField] private float speed;
    public PlayerScriptableObject m_data;
    



    private void CursorVisible()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {
        CursorVisible();
    }

    private void Update()
    {
        Move(GetMovement());
        Rotate(GetRotation());      
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (f_off)
            {
                p_light.SetActive(true);
                f_off = false;
            }
            else
            {
                p_light.SetActive(false);
                f_off = true;
            }
        }
    }

    private void Rotate(Vector2 p_scrollDelta)
    {
        transform.Rotate(Vector3.up, p_scrollDelta.x * Time.deltaTime * m_data.rotationSpeed, Space.Self);
    }

    private Vector2 GetRotation()
    {
        var l_mouseY = Input.GetAxis("Mouse Y");
        var l_mouseX = Input.GetAxis("Mouse X");
        return new Vector2(l_mouseX, l_mouseY);
    }

    private Vector3 GetMovement()
    {
        l_horizontal = Input.GetAxis("Horizontal");
        l_vertical = Input.GetAxis("Vertical");
        if (Input.GetButton("Horizontal"))
        {
            run.Pause();

        }
        if (Input.GetButton("Vertical"))
        {
            run.Pause();

        }
        return new Vector3(l_horizontal, 0, l_vertical).normalized;
    }

    private void Move(Vector3 m_player)
    {
        var transform1 = transform;
        if (Input.GetKey("left shift"))
        {
            run.Play();
            speed = m_data.runSpeed;
        }
        else
        {
            run.Pause();
            speed = m_data.speed;
        }
        transform1.position += (m_player.z * transform1.forward + m_player.x * transform1.right) *
                               (speed * Time.deltaTime);
    }
}
