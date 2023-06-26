using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<string> m_itemList = new List<string>();
    
    public void Add(string l_item)
    {
        m_itemList.Add(l_item);
        Debug.Log($"Has recogido la {l_item}, presiona F para encenderla");
    }

    public void ShowThis()
    {
        foreach(string p_item in m_itemList)
        {
            Debug.Log(p_item);
        }
    }
}
