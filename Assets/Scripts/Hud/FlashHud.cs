using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlashHud : MonoBehaviour
{
    [SerializeField] private float i_time2 = 4;
    private float c_time2;
    [SerializeField] private TMP_Text m_text;
    private bool m_bool;

    void Start()
    {
        c_time2 = i_time2;
    }

    public void FlashTutorial()
    {
        m_text.text = "Presiona F para encender la linterna";
        m_bool = true;
        
    }

    void Update()
    {
        if (m_bool)
        {
            c_time2 -= Time.deltaTime;
            if (c_time2 < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

