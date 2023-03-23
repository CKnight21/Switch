using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    public GameObject door;

    bool isOn;

    void OnTriggerEnter(Collider collider)
    {
        isOn = true;

        if(isOn == true)
        {
            isOn = true;
            door.SetActive(true);
            return;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        isOn = false;

        if (isOn == false)
        {
            isOn = false;
            door.SetActive(false);
            Debug.Log("Door invisable");
            return;
        }
    }

}
