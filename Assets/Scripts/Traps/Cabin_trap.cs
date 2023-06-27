using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabin_trap : MonoBehaviour
{
    [SerializeField] private RunHud run;

    private void OnTriggerEnter(Collider player)
    {
        run.ShowText();
    }
}
