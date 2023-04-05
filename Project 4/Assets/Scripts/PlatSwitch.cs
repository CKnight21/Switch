using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatSwitch : MonoBehaviour
{
    [SerializeField]
    public GameObject platforms;

    bool isOn;

    void OnTriggerEnter(Collider collider)
    {
        isOn = true;

        if (isOn == true)
        {
            isOn = true;
            platforms.SetActive(true);
            return;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        isOn = false;

        if (isOn == false)
        {
            isOn = false;
            platforms.SetActive(false);
            Debug.Log("Door invisable");
            return;
        }
    }

}
