using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //executing coroutine. cannot stop using this method
        StartCoroutine(executeSomething());

        //using this second method allows us to stop at any point we choose by calling the stop coroutine
        StartCoroutine("executeSomething");
        StopCoroutine("executeSomething");
    }

    // Update is called once per frame
    void Update () {

	}

    //coroutine (used for delayed behavior)
    //works same as normal function except returns IEnumerator and has yiled return statement
    IEnumerator executeSomething()
    {

        //give delay till executes for however many seconds you choose.
        yield return new WaitForSeconds(2f);

        Debug.Log("Waited two seconds");
    }


}//end of file
