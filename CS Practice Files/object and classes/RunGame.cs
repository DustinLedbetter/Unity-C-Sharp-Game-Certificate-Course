using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGame : MonoBehaviour {

    //Create Player Objects
    Player warrior;
    Player mage;

    // Use this for initialization
    void Start () {

        //created object from Player class
        warrior = new Player(90, 120, "warrior");
        mage = new Player(20, 50, "mage");
        warrior.Info();
        mage.Info();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
