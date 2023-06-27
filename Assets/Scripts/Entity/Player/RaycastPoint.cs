using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using System;

public class RaycastPoint : MonoBehaviour
{
    [SerializeField] private Transform m_raycastPoint;
    [SerializeField] private float m_maxDistance;
    [SerializeField] private LayerMask m_raycastLayers;
    private bool doorStade = false;
    [SerializeField] private string sceneName;
    private bool m_key, c_key,time_1,time_2;
    private bool time_3 = true;
    [SerializeField] private FlashHud m_flash;
    [SerializeField] private GetingKey m_text,d_text,g_text;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DoRaycast();
        }
    }

    private void DoRaycast()
    {
        bool l_isHitting = Physics.Raycast(m_raycastPoint.position, m_raycastPoint.forward,out RaycastHit hit, m_maxDistance, m_raycastLayers);

        if (l_isHitting)
        {
            if (hit.collider.TryGetComponent(out Items c_item))
            {     
                if(c_item.type == "FlashLight")
                {
                    m_flash.FlashTutorial();
                }
                GameManager.Instance.AddItem(c_item);
                c_item.Collected();
            }
            else if (hit.collider.TryGetComponent(out Collectibles c_object))
            {
                GameManager.Instance.AddScore(1);
                c_object.Collected();
            }
            else if(hit.collider.TryGetComponent(out DoorController c_door))
            {
                
                if (doorStade)
                {
                    c_door.CloseDoor();
                    doorStade = false;
                }
                else
                {
                    c_door.OpenDoor();
                    doorStade = true;
                }
            }
            else if(hit.collider.TryGetComponent(out DoorLockedController l_door))
            {
                l_door.LockDoor();
            }

            if(hit.collider.TryGetComponent(out Key k_get))
            {
                m_key = true;
            }

            if (hit.collider.TryGetComponent(out PassKey c_get))
            {
                
                if (time_3)
                {
                    m_text.ShowText();
                    time_3 = false;
                    time_2 = true;
                }else if (time_2)
                {
                    d_text.ShowText();
                    time_2 = false;
                    time_1 = true;
                }else if (time_1)
                {
                    g_text.ShowText();
                    time_1 = false;
                }
            
            
        }

            if (m_key)
            {
                if (hit.collider.TryGetComponent(out PlayButton l_pass))
                {
                    SceneManager.LoadScene(sceneName);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider m_player)
    {
        m_key = true;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(m_raycastPoint.position, m_raycastPoint.position + m_raycastPoint.forward * m_maxDistance);
    }
}
