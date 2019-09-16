using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
	//Set up public access variable to refer to another Object
	public GameObject other;

	void Update ()
	{
		if(Input.GetKey(KeyCode.Space))//Use of the get Componenet function to refer to a component
		{
			Destroy(other);//the GameObject Variable other is destroyed - In Unity inspector window drag and drop another Object called other into the other variable box in the inspector window
		}
	}
}