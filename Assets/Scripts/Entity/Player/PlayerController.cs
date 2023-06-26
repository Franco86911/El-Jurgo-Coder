using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    [SerializeField] private float rotationSpeed = 1f;
    private float l_vertical;
    private float l_horizontal;
    private bool isSprinting;
    private bool isCooldown;
    private float sprintTimer;
    private float sprintTime;
    private Rigidbody rb;
    [SerializeField] private Transform m_target;
    private float e_nearLimit = 2;
    //[SerializeField] private AudioSource step;
    [SerializeField] private AudioSource run;
    [SerializeField] private GameObject p_light;
    private bool f_off = true;

    private void CursorVisible()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {
        CursorVisible();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        
    }

    void Update()
    {
        var t_diffVector = m_target.position - transform.position;
        if (e_nearLimit < t_diffVector.magnitude)
        {
            Move(GetMovement());
            Rotate(GetRotation());
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameManager.Instance.ShowItems();
        }
        
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
        transform.Rotate(Vector3.up, p_scrollDelta.x * Time.deltaTime * rotationSpeed, Space.Self);
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
        if(Input.GetButton("Horizontal"))
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
        if (!isCooldown && Input.GetKey("left shift"))
        {
            isSprinting = true;
            sprintTimer += Time.deltaTime;
            run.Play();
        }
        else
        {
            run.Pause();
            isSprinting = false;
            sprintTimer -= Time.deltaTime;
            
        }
        sprintTimer = Mathf.Clamp(sprintTimer, 0f, sprintTime);

        if (isSprinting)
        {
            speed = 7f;
        }
        else
        {
            speed = 3f;
        }

        if (sprintTimer >= sprintTime)
        {
            isCooldown = true;
        }
        if (sprintTime <= 0f)
        {
            isCooldown = false;
        }
        transform1.position += (m_player.z * transform1.forward + m_player.x * transform1.right) *
                               (speed * Time.deltaTime);
    }

    //private void SpeedLimit()
    //{
    //    Vector3 velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
    //    if (velocity.magnitude > speed)
    //    {
    //        Vector3 limitVelocity = velocity.normalized * speed;
    //        rb.velocity = new Vector3(limitVelocity.x, rb.velocity.y, limitVelocity.z);
    //    }
    //}
}
