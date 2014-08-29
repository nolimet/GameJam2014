using UnityEngine;
using System.Collections;

public class Score {

	public static int multiplierScore = 1;
	public static int multiplierCounter = 0;

	public static void addScore ()
	{
        Statics.Score += 20 * multiplierScore;
		multiplierCounter++;

        if (Statics.Score > Statics.HighestScore)
        {
            Statics.HighestScore = Statics.Score;
        }

		if (multiplierCounter >= 10) 
		{

			multiplierScore++;
			multiplierCounter = 0;
		}
	}

	public static void mistake ()
	{
		multiplierCounter = 0;
		multiplierScore = 1;
        Debug.Log("Missed");
	}
}
