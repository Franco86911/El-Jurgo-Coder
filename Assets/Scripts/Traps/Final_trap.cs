using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_trap : MonoBehaviour
{
    [SerializeField] private GameObject lamp_off1, lamp_off2;

   private void OnTriggerEnter(Collider col)
   {
        lamp_off1.SetActive(false);
        lamp_off2.SetActive(false);
   }
}
