using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class handScript : MonoBehaviour
{
    public GameObject pickedUpObject;

    private void OnTriggerEnter(Collider other)
    {
        pickedUpObject = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input.GetStateDown("GrabPinch", SteamVR_Input_Sources.Any)){
            pickedUpObject.transform.parent = this.transform;

            pickedUpObject.GetComponent<Rigidbody>().isKinematic = true;

        }

        if(SteamVR_Input.GetStateUp("GrabPinch", SteamVR_Input_Sources.Any))
        {

            pickedUpObject.GetComponent<Rigidbody>().isKinematic = false;

            pickedUpObject.transform.parent = null;
        }
        
    }
}
