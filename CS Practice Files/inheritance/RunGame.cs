using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGame : MonoBehaviour {


    // Use this for initialization
    void Start () {

        Warrior war = new Warrior();
        war.Info();
        war.Attack();
    }
	

	// Update is called once per frame
	void Update () {
		
	}


    ////functions for collision for later in course
    //private void OnTriggerEnter2D(Collider2D target)
    //{

    //}

}
