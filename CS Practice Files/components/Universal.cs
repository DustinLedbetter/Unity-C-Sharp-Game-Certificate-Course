using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universal : MonoBehaviour {

    //creating variables to hold components
    Animator anim;
    Rigidbody2D myRigidBody;

	// Use this for initialization
	void Start () {

        //calling components
        anim = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();
        Universal script = GetComponent<Universal>();

        //do not need to create a variable to hold this component
        transform.position

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
