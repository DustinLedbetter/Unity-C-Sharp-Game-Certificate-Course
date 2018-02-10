using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    //array of ten elements (0-9)
    int[] nums = new int[10];


    // Use this for initialization
    void Start()
    {

        //last number in array is one less than length
        //nums.Length - 1;

        //use a for loop to fill array with random numbers
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Random.Range(1, 100);
        }

        //print out array showing numbers added to array
        for (int i = 0; i < nums.Length; i++)
        {
            Debug.Log("Element: " + i + " is " + nums[i]);
        }

    }

    // Update is called once per frame
    void Update () {

	}

}//end of file
