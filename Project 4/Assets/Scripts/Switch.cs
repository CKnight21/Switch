using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    public GameObject thingToSwtich;

    bool isOn;

   

    void OnTriggerEnter(Collider collider)
    {
        isOn = true;

        if(isOn == true)
        {
            isOn = true;
            thingToSwtich.SetActive(true);
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Animator>().Play("SwitchOn");
            return;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        isOn = false;

        if (isOn == false)
        {
            isOn = false;
            thingToSwtich.SetActive(false);
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Animator>().Play("SwitchOff");
            Debug.Log("Door invisable");
            return;
        }
    }

}
