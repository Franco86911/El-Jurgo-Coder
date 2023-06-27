using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetingKey : MonoBehaviour
{
    [SerializeField] private TMP_Text m_text;
    [SerializeField] private float i_time2 = 4;
    public float c_time2;
    private bool m_bool;

    void Start()
    {
        c_time2 = i_time2;
    }

    public void ShowText()
    {
        m_text.text = "Llave Obtenida";
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

