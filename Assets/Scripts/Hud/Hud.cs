using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hud : MonoBehaviour
{
    [SerializeField] private float i_time = 1;
    private float c_time;
    [SerializeField] private float i_time2 = 4;
    private float c_time2;
    [SerializeField] private TMP_Text m_text;
    [SerializeField] private string f_text;

    void Start()
    {
        c_time = i_time;
        c_time2 = i_time2;
    }

    
    void Update()
    {
        c_time -= Time.deltaTime;
        if (c_time < 0)
        {
            m_text.text = f_text;
            c_time2 -= Time.deltaTime;
            if (c_time2 < 0)
            {
                m_text.text = " ";
            }
        }
        if(c_time < 0 && c_time2 < 0)
        {
            Destroy(gameObject);
        }
    }
}
