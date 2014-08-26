using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	private int score = 0;
	private int multiplierScore = 1;
	private int multiplierCounter = 0;

	public void enemyKilled ()
	{
		score += 20 * multiplierScore;
		multiplierCounter++;
		if (multiplierCounter == 10) 
		{
			multiplierScore++;
			multiplierCounter = 0;
		}
	}

	public void mistake ()
	{
		multiplierCounter = 0;
		multiplierScore = 0;
		score -= 20 * multiplierScore;
	}

	public void gameEnd () 
	{
		if (score > PlayerPrefs.GetInt("Highscore"))
		{
			PlayerPrefs.SetInt("Highscore",score);
		}
	}
}
