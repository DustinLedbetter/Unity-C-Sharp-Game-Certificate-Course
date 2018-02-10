using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

      //holding ctrl + k and ctrl + c will comment all selected items
        //holding ctrl + k and ctrl + u will uncomment all selected items

        //variables
        int speed = 5;
        int maxSpeed = 3;


        ////showing an if statement when true
        //if (true)
        //{
        //    Debug.Log("The code is executed");
        //}


        ////if testing a condition
        //if (2 <= 3)
        //{
        //    Debug.Log("The code is executed");
        //}


        ////testing a condition with if/else
        //if (speed >= maxSpeed)
        //{
        //    Debug.Log("The speeed is greater than max speed");
        //}
        //else
        //{
        //    Debug.Log("The speeed is less than max speed");
        //}


        ////testing multiple conditions with if/else
        //if (speed >= maxSpeed)
        //{
        //    Debug.Log("The speeed is greater than max speed");
        //}
        //else if (speed == maxSpeed)
        //{
        //    Debug.Log("The speeed is equal to max speed");
        //}
        //else if (speed < maxSpeed)
        //{
        //    Debug.Log("The speeed is less than max speed");
        //}


        //testing nested if/else conditions
        if (speed >= maxSpeed)
        {

            if (speed > 4)
            {
                Debug.Log("The speeed is greater than 4");
            }
            else if (speed == 3)
            {
                Debug.Log("The speeed is equal to 3");
            }
            else
            {
                Debug.Log("The speeed is greater than max speed");
            }

        }
        else if (speed == maxSpeed)
        {
            Debug.Log("The speeed is equal to max speed");
        }
        else if (speed < maxSpeed)
        {
            Debug.Log("The speeed is less than max speed");
        }


        //pass item to check in switch and make cases for each option
        switch (speed)
        {

            //if (speed) is equal to (1) then execute code from this case
            case 1:
                Debug.Log ("The speed is 1");
                break;
            //if (speed) is equal to (2) then execute code from this case
            case 2:
                Debug.Log("The speed is 2");
                break;
            //if (speed) is equal to (3) then execute code from this case
            case 3:
                Debug.Log("The speed is 3");
                break;
            //if (speed) is equal to (4) then execute code from this case
            case 4:
                Debug.Log("The speed is 4");
                break;
            //default is used as "else" when no case fits
            default:
                Debug.Log("The default has been executed");
                break;
        }

    }

    // Update is called once per frame
    void Update () {

	}

}//end of file
