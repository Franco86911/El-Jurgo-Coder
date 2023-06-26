using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashHud : MonoBehaviour
{
    [SerializeField] private float i_time = 1;
    private float c_time;
    [SerializeField] private float i_time2 = 4;
    private float c_time2;
    [SerializeField] private GameObject text;

    void Start()
    {
        c_time = i_time;
        c_time2 = i_time2;
    }


    private void FlashTutorial()
    {
        c_time -= Time.deltaTime;
        if (c_time < 0)
        {
            text.SetActive(true);
            c_time2 -= Time.deltaTime;
            if (c_time2 < 0)
            {
                text.SetActive(false);
            }
        }
    }
}

