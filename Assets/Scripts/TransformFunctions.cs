using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctions : MonoBehaviour
{
    // Set variables moveSpeed and turnSpeed to type float and public access with values 10f and 50f
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
   

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0,0,3));//Instead of the code to the left which is (Vector3 set to 0 x axis, 0 y axis, and 3 for z axis speed) we use the code below =

        if (Input.GetKey(KeyCode.UpArrow))//Only occurs when Up Arrow key is pushed
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);//Mutiply the Translate Operation by Time.deltaTime - changes the Object to be moved in meters per second instead of frames per second

        if (Input.GetKey(KeyCode.DownArrow))//Only occurs when Up Down key is pushed
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);//- negative operator used for Vector3 to move backward

        if (Input.GetKey(KeyCode.LeftArrow))//Only occurs when Up Left key is pushed
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);//vector3.up represents the axis  around which to turn

        if (Input.GetKey(KeyCode.RightArrow))//Only occurs when Up Right key is pushed
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
