using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponents : MonoBehaviour
{
	void Update ()
	{
		if(Input.GetKey(KeyCode.Space))//Use of the get Componenet function to refer to a component
		{
			Destroy(GetComponent<GameObject>());//Destroy a single Component with the GetComponent Function within the Destroy parenthesis 
		}
	}
}
