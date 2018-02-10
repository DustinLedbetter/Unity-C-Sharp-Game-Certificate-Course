public class MyScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		//either debug or print way can be used to print to the console
		Debug.Log ("Printed from script.");
		print ("Here is a string");

		//using variables fro mathmatical problem 1
		int a = 2 / 3;
		int b = 2;
		int c = 3;
		int d = b + c;

		//print out results
		Debug.Log ("2 + 3 = " + d);

		//using variables fro mathmatical problem 2
		int e = 5;
		int f = 2;
		int g = e - f;

		//print out results
		Debug.Log ("5 - 2 = " + g);

		//using variables fro mathmatical problem 3
		float h = 5f;
		float i = 2f;
		float j = h/i;

		//print out results
		Debug.Log ("5/2 = " + j);

		//using variables fro mathmatical problem 4

		//no variables needed outside console statement

		//print out results
		Debug.Log ("5 + 2 = " + (5 + 2));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
