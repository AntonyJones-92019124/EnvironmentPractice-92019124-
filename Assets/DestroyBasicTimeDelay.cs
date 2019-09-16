using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasicTimeDelay : MonoBehaviour
{
	void Update ()
	{
		if(Input.GetKey(KeyCode.Space))//Use of the get Componenet function to refer to a component
		{
			Destroy(gameObject, 3f);//3f for the second argument added for a 3 second delay before Object is removed.
		}
	}
}