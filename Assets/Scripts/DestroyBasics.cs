using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasics : MonoBehaviour
{
	void Update ()
	{
		if(Input.GetKey(KeyCode.Space))//Use of the get Componenet function to refer to a component
		{
			Destroy(gameObject);//
		}
	}
}