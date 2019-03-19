using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
    [SerializeField]
    private Raycast raycast;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && raycast.LookAtInteractive != null)
        {
            Debug.Log("Player pressed the interact button.");
            raycast.LookAtInteractive.InteractWith();
            
        }
    }
}
