using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour {

	//variables
	public InputField input;
	public Text infoText;
	private int guessNumber;
	private int userGuess;

	//initialization
	void Start () {
		
		//generate a random number for user to guess
		guessNumber = Random.Range (0, 100);

	}
	
	// Update is called once per frame
	public void CheckGuess () {

		//convert user text of number to an integer to test against random generated number
		userGuess = int.Parse (input.text);

		if (userGuess == guessNumber) {
			infoText.text = "You Guessed The Number! You Are A Wizard!";
		} else if (userGuess > guessNumber) {
			infoText.text = "Your Number Is Greater Than The Guess Number";
		} else if (userGuess < guessNumber) {
			infoText.text = "Your Number Is Lower Than The Guess Number";
		}

		//remove the previous guess from input field
		input.text = "";
	}

	public void EndGame () {

		//call to close the game after won
		Application.Quit();
	}

} //end class
