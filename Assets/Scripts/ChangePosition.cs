using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour {

    //Create variable vector3 to variable newPosition with public access
    public Vector3 newPosition;

    //New variable for Transform componenet
    private Transform thisTransform = null;

	// Use this for initialization
	void Start ()
    {
        thisTransform = GetComponent<Transform> ();//Inside the start function when the level begins we want to get a -
                                                   //Refference to the Transform Component on the Object we attached it to this is achieved with the this.Transform = GetComponent<Transform> (); 
                                                   //This code grabs the Transform Component attached to the Object, and attaches it with a refference inside the this.Transform code meaning -
                                                   //On all lines after the this.Transform the this.Tranform will refer to the Transform Component.

                                            
                                                       
        this.thisTransform.position = newPosition;//this.Transform is set to the Current Position we set the -
                                                  //New Postion value of the newPostion Variable that we gave to it in unity inspector window  - script variable box
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
