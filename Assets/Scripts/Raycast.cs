using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    private Transform RaycastOrigin;

    [SerializeField]
    private float maxRange = 5.0f;

    private Vector3 RaycastDirection;


    private void FixedUpdate()
    {
        
        Debug.DrawRay(RaycastOrigin.position, RaycastOrigin.forward * maxRange, Color.red);
        RaycastHit hitInfo;
        bool ObjectWasDetected = Physics.Raycast(RaycastOrigin.position, RaycastOrigin.forward, out hitInfo, maxRange);

        if(ObjectWasDetected)
        {
            Debug.Log($"Player is looking at { hitInfo.collider.gameObject.name}");
        }
    }
}
