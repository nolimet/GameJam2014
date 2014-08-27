using UnityEngine;
using System.Collections;

public class Pauze : MonoBehaviour {

	private bool paused = false;
	private int difficult = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.P)) 
		{
			if(paused)
			{
				paused = false;
				Time.timeScale = difficult;
			}
			else
			{
				paused = true;
				Time.timeScale = 0;
			}
		}
	}
}
