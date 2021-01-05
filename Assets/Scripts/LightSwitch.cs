using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightSwitch : MonoBehaviour {

    public bool onSwitch;
    public bool lightStatus;
    public GameObject theLight;

	void onStart()
    {
        onSwitch = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        onSwitch = false;
    }

    void OnTriggerExit(Collider other)
    {
        onSwitch = true;
    }

    void Update()
    {
        if(theLight.active == true)
        {
            lightStatus = false;
        }
        else
        {
            lightStatus = true;
        }

        if (onSwitch)
        {
            if (lightStatus)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    theLight.active = true;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    theLight.active = false;
                }
            }
        }
    }

    void OnGUI()
    {
        if (onSwitch)
        {
            if (lightStatus)
            {
                GUI.Box(new Rect(0, 0, 200, 20), "Press E to turn on the light");

            }
            else
            {
                GUI.Box(new Rect(0, 0, 200, 20), "Press E to turn off the light");
            }
        }
    }
}