using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCoolClass : MonoBehaviour
{
	//First variable accessed by public accesserfier and of type int
	public int anInt;

	//String Variale of public access of string type
	public string aString;

	//Boolean Variable type with public access
	public bool aBool;

	//A Object Variable type with public access.
	public GameObject gameObj;

	//Private access variables need the [SerializeField] before the declaration as they don't show up in the inspector window by default
	[SerializeField]
	private int PrivateInt;

	// Start is called before the first frame update
	void Awake()
	{

	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	//Create a function
	private bool foo(int i)
	{
		return true;
	}
}
