using UnityEngine;
using System.Collections;

public class audioStart : MonoBehaviour {
	private int counter;

	// Update is called once per frame
	void Update () {
		counter += 1;
		if (counter == 25)
						StartMusic ();
	}
	void StartMusic(){
		//print ("hahahaha");
		//audio.Play ();
	}
}
