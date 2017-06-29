﻿using UnityEngine;
using System.Collections;
public class NumberWizard : MonoBehaviour {
	int max,min;
	int mid;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	void StartGame() {
		max = 1000;
		min=1;
		mid=500;
		print("========================");
		print("WELCOME TO NUMBER WIZARD"); 
		print ("Pick a number in your mind,but don't tell me!");
		print ("highest no to pick is "+max);
		print ("lowest no to pick is "+min);
		print ("is your number higher or lower than "+mid);
		print ("Press:UP=higher,DOWN=lower,or ENTER=equal to it");
		max=max+1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			//print("UP ARROW pressed");
			min=mid;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			//print("DOWN ARROW pressed");
			max=mid;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return)){
			print("I WONN!!!");
			StartGame();
		}
	}		
	void NextGuess(){
		mid=((max+min)/2);
		print("Higher or lower than "+mid);
		print("Press:UP=higher,DOWN=lower,or ENTER=equal to it");
	}
}		