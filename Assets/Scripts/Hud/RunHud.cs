using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RunHud : MonoBehaviour
{
    [SerializeField] private float i_time = 4;
    private float c_time;
    [SerializeField] private TMP_Text m_text;

    void Start()
    {
        c_time = i_time;
    }


    public void ShowText()
    { 
        m_text.text = "Manten SHIFT para esprintar";
        c_time -= Time.deltaTime;
        if (c_time < 0)
        {
            Destroy(gameObject);
        }
    }
}
