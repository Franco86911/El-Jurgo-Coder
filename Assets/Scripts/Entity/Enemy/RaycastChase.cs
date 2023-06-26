using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastChase : MonoBehaviour
{
    [SerializeField] private Transform m_raycastPoint;
    [SerializeField] private float m_maxDistance;
    [SerializeField] private LayerMask m_raycastLayers;
    public static bool e_detected = false;

    void Update()
    {
        DoRaycast();
    }

    private void DoRaycast()
    {
        bool l_isHitting = Physics.Raycast(m_raycastPoint.position, m_raycastPoint.forward, out RaycastHit hit, m_maxDistance, m_raycastLayers);


        if (l_isHitting)
        {            
            if (hit.collider.TryGetComponent(out PlayerController l_player))
            {
                e_detected = true;
                Debug.Log("true");
            }
            e_detected = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(m_raycastPoint.position, m_raycastPoint.position + m_raycastPoint.forward * m_maxDistance);
    }
}
