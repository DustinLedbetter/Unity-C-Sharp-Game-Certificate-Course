using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        //using the for loop to print multiple lines
        for (int i = 1; i <= 10; i++)
        {
            //using i in print statement to have it show incrementing number
            Debug.Log("Printed " + i);
        }

        //using while loop to print multiple lines
        int a = 0;

        while (a <= 10)
        {
            Debug.Log("Printed " + a);
            a++;
        }

    }

    // Update is called once per frame
    void Update () {

	}

}//end of file
