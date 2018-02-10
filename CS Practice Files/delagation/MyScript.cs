using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

	// Use this for initialization
	void Awake () {

        //popup window asking if you want to subcribe to email list (+= means you did subcribe)
        //1.) this is adding the someFunction to Tester's Printer in the Tester file
        Tester.Printer += someFunction;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //3.) this function is executed in Tester's start function
    void someFunction()
    {
        Debug.Log("Handling the event");
    }
}
