using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CCMovementScript : MonoBehaviour
{
    private CharacterController controller;
    private float playerSpeed = 2.0f;
    public SteamVR_Action_Vector2 moveValue;
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, 0, moveValue.axis.y);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if(move!= Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}
