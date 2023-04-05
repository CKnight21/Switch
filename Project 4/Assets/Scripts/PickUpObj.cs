using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObj : MonoBehaviour
{
    private Rigidbody objectRigibody;

    private Transform objectGrabPointTransform;

    public float lerpSpeed = 10f;

    private void Awake()
    {
        objectRigibody = GetComponent<Rigidbody>();
    }

    public void Grab(Transform ojectGrabPointTransform)
    {
        this.objectGrabPointTransform = ojectGrabPointTransform;
        objectRigibody.useGravity = false;
    }

    public void Drop()
    {
        this.objectGrabPointTransform = null;
        objectRigibody.useGravity = true;
    }

    private void FixedUpdate()
    {
        if(objectGrabPointTransform != null)
        {
            
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigibody.MovePosition(newPosition);
        }
    }
}
