using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int id;
    public string type;
    private Renderer rend;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public void Collected()
    {
        rend.enabled = false;
    }
}
