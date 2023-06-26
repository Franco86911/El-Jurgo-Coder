using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
   public enum EnemyTypes
    {
        Watcher,
        Persecutor,
    }

    [SerializeField] private Transform m_target;
    //[SerializeField] private float e_movementSpeed;
    //[SerializeField] private float e_distanceToChase = 20;
    //[SerializeField] private float e_speedRotation;
    //public float e_nearLimit = 2;
    [SerializeField] private EnemyTypes e_type;
    [SerializeField] private float i_responseTime = 2f;
    private float c_responseTime;
    private Rigidbody rb;
    [SerializeField] private AudioSource m_audio;
    [SerializeField] private AudioClip steps;
    private float i_stepTime = 0.34f;
    private float c_stepTime;
    private RaycastChase p_detected;
    public EnemyScriptableObject m_data;

    void Start()
    {
        c_responseTime = i_responseTime;
        c_stepTime = i_stepTime;
    }
 
    void Update()
    {
        switch (e_type)
        {
            case EnemyTypes.Watcher:
                Look();
                break;
            case EnemyTypes.Persecutor:
                Tracking();
                break; 
        }
    }

    private void Tracking()
    {
        var t_diffVector = m_target.position - transform.position;
        if (m_data.e_distanceToChase > t_diffVector.magnitude && t_diffVector.magnitude > m_data.e_nearLimit)
        {
            
            c_responseTime -= Time.deltaTime;
            if ((c_responseTime < 0) && (p_detected))
            {
                Quaternion newRotation = Quaternion.LookRotation(t_diffVector.normalized);
                transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, m_data.r_speed * Time.deltaTime);
                Move(t_diffVector.normalized);
            }
        }       
    }

    private void Look()
    {
        var l_diffVector = m_target.position - transform.position;
        if (m_data.e_distanceToChase > l_diffVector.magnitude)
        {
            Quaternion newRotation = Quaternion.LookRotation(l_diffVector.normalized);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, m_data.r_speed * Time.deltaTime);
        }
    }

    private void Move(Vector3 p_direction)
    {
        c_stepTime -= Time.deltaTime;
        transform.position += p_direction * (m_data.speed * Time.deltaTime);
        if (c_stepTime < 0) 
        {
            GetComponent<AudioSource>().PlayOneShot(steps, 1f);
            c_stepTime = i_stepTime;
        }
    }
}
