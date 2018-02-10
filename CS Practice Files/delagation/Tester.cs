using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour {


    public delegate void Print();
    //email list
    public static event Print Printer;

	// Use this for initialization
	void Start () {

        //check if i have somebody in my email list. if true then send the email
        //2.) The someFunction from MyScript is executed in this start function as long as Printer has been assigned the function
        if(Printer != null)
        {
            Printer();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
