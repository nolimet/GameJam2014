using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TextMesh))]
public class ScoreUpdater : MonoBehaviour {

    TextMesh txme;

    void Start()
    {
       txme = GetComponent<TextMesh>();
    }

    void Update()
    {
        txme.text = "Score: " + Statics.Score + '\n' + "HighScore: " + Statics.HighestScore;
    }
}
