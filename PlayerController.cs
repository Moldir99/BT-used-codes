// Responsible for player movement using left-hand controller
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    // input to trigger movement
    public SteamVR_Action_Vector2 input; 
    public float speed = 3;
    private CharacterController characterController;

    private void Start()
    {
        // Accessing character controller of the player
        characterController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        // For the movement of the player according to the facing dircetion with headset
        Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
        //transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direction,Vector3.up);
        // modifying player position through character controller;
        characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0,9.81f,0)*Time.deltaTime);
    
    }
}
