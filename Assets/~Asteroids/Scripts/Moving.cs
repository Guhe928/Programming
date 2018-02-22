using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Clean Code: CTRL + K + D (in that order)
// {} - Braces
// [] - Brackets
// () - Parenthesis


public class Moving : MonoBehaviour
{
    //Member Variables
    public float movementSpeed = 10;
    public float rotationSpeed = 360;
    public float movementSpeedback = 5;
    //Void = Create new function.

    void Rotation()
    {
        //Rotate Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
        }
        //Rotate Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

        }
    }
    void Movement()
    {
        // If the player is pressing the UP arrow
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the player up by movementSpeed
            //Vector3 position = transform.position;
            //position.y += movementSpeed * Time.deltaTime;
            //transform.position = position;
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }

        //Move Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //Call Movement Function
        Movement();
        Rotation();
          

        
        
    }
}
