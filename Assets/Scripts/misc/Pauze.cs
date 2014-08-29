using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TextMesh))]
public class Pauze : MonoBehaviour {

	private bool paused = false;
	private int difficult = 1;
	TextMesh txme;

	void Start ()
	{
		txme = GetComponent<TextMesh>();
	}

	void Update () 
	{
		if (Input.GetKeyUp (KeyCode.P)) 
		{
			if(paused)
			{
				paused = false;
				Time.timeScale = difficult; //spel gaat door op de vooraf gestelde snelheid
				//GameObject.Find ("audio source Muted").audio.Play();
				GameObject.Find ("Directional light").light.intensity = 0.28f;
				txme.text = " ";
			}
			else
			{

				paused = true;
				Time.timeScale = 0;			//spel stopt tijdelijk tot je weer opnieuw op p drukt
				//GameObject.Find ("audio source Muted").audio.Pause();
				GameObject.Find ("Directional light").light.intensity = 0.1f;
				txme.text = "Paused";
			}
		}
	}

	void OnGUI ()
	{
		if (paused) 
		{
			if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 10, 200, 20), "Main Menu")) {
				Application.LoadLevel ("menu");
			}
		}
	}
}