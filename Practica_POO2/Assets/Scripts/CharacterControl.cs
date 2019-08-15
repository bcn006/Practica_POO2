using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Animator anim;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    #region variable rotacion 
    [Range(0.01f, 5.0f)]
    public float speedRotation;
    #endregion

    void Start()
    {
        speedRotation = 1.0f;
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotAxis = Input.GetAxis("Mouse X");
        Vector3 mosuePos = Input.mousePosition;

        if (controller.isGrounded)
        {
            //We are grounded, so recalculate
            //move direction directly from axes 

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed; 

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed; 
            }
        }
        //Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
        //Move the controller 
        controller.Move(moveDirection * Time.deltaTime);
        //Rotate
        transform.Rotate(Vector3.up * rotAxis * speedRotation);


        //Animation 
        anim.SetFloat("Velocidad", moveDirection.z);
        anim.SetFloat("veloLateral", moveDirection.x);

        //Attack Controller
        if (Input.GetMouseButton(0))
        {
            anim.SetLayerWeight(1, 1);
            //Shoot(); 
        }
        else
        {
            anim.SetLayerWeight(1, 0);
        }
    }
}
