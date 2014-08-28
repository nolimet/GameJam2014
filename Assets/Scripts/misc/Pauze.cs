﻿using UnityEngine;
using System.Collections;

public class Pauze : MonoBehaviour {

	private bool paused = false;
	private int difficult = 1;

	void Update () {
		if (Input.GetKeyUp (KeyCode.P)) 
		{
			if(paused)
			{
				paused = false;
				Time.timeScale = difficult; //spel gaat door op de vooraf gestelde snelheid
				GameObject.Find ("SpawnChecker").audio.Play();
				GameObject.Find ("Directional light").light.intensity = 0.28f;
			}
			else
			{
				paused = true;
				Time.timeScale = 0;			//spel stopt tijdelijk tot je weer opnieuw op p drukt
				GameObject.Find ("SpawnChecker").audio.Pause();
				GameObject.Find ("Directional light").light.intensity = 0.1f;

			}
		}
	}
}
