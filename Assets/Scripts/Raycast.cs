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

    public IInteractive LookAtInteractive
    {
      get { return lookAtInteractive;  }
      set { lookAtInteractive = value; }

    }

    private IInteractive lookAtInteractive;



    private void FixedUpdate()
    {
        
        Debug.DrawRay(RaycastOrigin.position, RaycastOrigin.forward * maxRange, Color.red);
        RaycastHit hitInfo;
        bool ObjectWasDetected = Physics.Raycast(RaycastOrigin.position, RaycastOrigin.forward, out hitInfo, maxRange);

        IInteractive interactive = null;

        LookAtInteractive = interactive;

        if(ObjectWasDetected)
        {
            //Debug.Log($"Player is looking at { hitInfo.collider.gameObject.name}");
            interactive = hitInfo.collider.gameObject.GetComponent<IInteractive>();
        }

        if(interactive != null)
        {
            LookAtInteractive = interactive;
        }
    }
}
