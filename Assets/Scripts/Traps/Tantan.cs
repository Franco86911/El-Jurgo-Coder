using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tantan : MonoBehaviour
{
    [SerializeField] private GameObject lamp_off1, lamp_off2, flickerlamp1, flickerlamp2;
    [SerializeField] private float i_time = 0.5f;
    private float f_time, f2_time;
    private bool actived;

    private void OnTriggerEnter(Collider m_player)
    {
            lamp_off1.SetActive(false);
            lamp_off2.SetActive(false);
            f_time = i_time;
            f2_time = i_time;
            actived = true;
    }

    void Update()
    {
        if (actived)
        {
            Flicker();
        }
        
    }

    private void Flicker()
    {
         f_time -= Time.deltaTime;
         f2_time -= Time.deltaTime;
         if(f_time > 0)
         {
             f2_time = i_time;
             flickerlamp1.SetActive(false);
             flickerlamp2.SetActive(false);
         }
         else 
         {
            if (f2_time < 0)
            {
                f_time = i_time; 
            }
            flickerlamp1.SetActive(true);
            flickerlamp2.SetActive(true);
         }
    }
}
