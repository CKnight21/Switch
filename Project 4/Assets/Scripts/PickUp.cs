using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Rigidbody boxRigidbody;

    public BoxCollider col;

    public Transform player, container, fpsCam;

    public float pickUpRange;

    public float dropFowardForce, dropUpwardForce;

    public bool equipped;

    public static bool slotFull;

    private void Start()
    {
        if(!equipped)
        {
            boxRigidbody.isKinematic = false;
            col.isTrigger = false;
        }
        if (equipped)
        {
            boxRigidbody.isKinematic = true;
            col.isTrigger = true;
            slotFull = true;
        }
    }

    private void Update()
    {
        Vector3 disToPlayer = player.position - transform.position;
        if (!equipped && disToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull)
            ItemPickUp();

        if (equipped && Input.GetKeyDown(KeyCode.Q))
            Drop();
    }

    private void ItemPickUp()
    {
        equipped = true;
        slotFull = true;

        transform.SetParent(container);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;

        boxRigidbody.isKinematic = true;
        col.isTrigger = true;
    }

    private void Drop()
    {
        equipped = false;
        slotFull = false;

        transform.SetParent(null);
        
        boxRigidbody.isKinematic = false;
        col.isTrigger = false;

        boxRigidbody.velocity = player.GetComponent<Rigidbody>().velocity;

        boxRigidbody.AddForce(fpsCam.forward * dropFowardForce, ForceMode.Impulse);
        boxRigidbody.AddForce(fpsCam.up * dropUpwardForce, ForceMode.Impulse);

        float random = Random.Range(-1f,1f);   
        boxRigidbody.AddTorque(new Vector3(random,random,random)*10);
    }
}
