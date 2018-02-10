using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //creating an object from Player class
        Player p1 = new Player();

        //view current power, set new power, view new power
        Debug.Log("The power is " + p1.GetPower());
        p1.SetPower(56);
        Debug.Log("The power is " + p1.GetPower());

        //view current health, set new health, view new health
        Debug.Log("The health is " + p1.GetHealth());
        p1.SetHealth(91);
        Debug.Log("The health is " + p1.GetHealth());

        //view current name, set new name, view new name
        Debug.Log("The Name is " + p1.GetName());
        p1.SetName("Mage");
        Debug.Log("The Name is " + p1.GetName());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
