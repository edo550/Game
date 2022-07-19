
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public Joystick joystick;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;





    // Update is called once per frame
    void Update()
    {

        if ((joystick.Horizontal >= .2f))
        {
            horizontalMove = runSpeed;
            GetComponent<AudioSource>().UnPause();
        }
        else if ((joystick.Horizontal <= -.2f))
        {
            horizontalMove = -runSpeed;
            GetComponent<AudioSource>().UnPause();
        }
        else
        {
            horizontalMove = 0f;
            GetComponent<AudioSource>().Pause();


        }


        float verticalMove = joystick.Vertical;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (verticalMove >= .5f) {
            
           // jump = true;
           // GetComponent<AudioSource>().Pause();

        }
        else if (verticalMove <= -.5f)
        {
            crouch = true;

        }else
        {
            crouch = false;
        }

    }



    public void Jumping() {
        //float verticalMove = joystick.Vertical;
        // if (verticalMove >= .5f)
        //{
            
            jump = true;
            animator.SetBool("IsJump", true);
            GetComponent<AudioSource>().Pause();

    }
    public void OnLanding()
    {
        animator.SetBool("IsJump", false);
        GetComponent<AudioSource>().Pause();
    }

    void FixedUpdate()
    {
        //Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}