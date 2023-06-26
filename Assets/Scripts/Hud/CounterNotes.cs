using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterNotes : MonoBehaviour
{
    public List<string> m_list = new List<string>();
    [SerializeField] private TMP_Text c_note;
    //[SerializeField] private List<note> n_number;
    private int t = 0;
    public void CounterN()
    {
        
        c_note.text = m_list[t];
        t += 1;
        
    }
    
}
