using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TextMesh))]
public class ScoreUpdater : MonoBehaviour {

    TextMesh txme;

    [SerializeField]
    bool Counter;


    void Start()
    {
       txme = GetComponent<TextMesh>();
    }

    void Update()
    {
        if (!Counter)
            txme.text = "Score: " + Statics.Score + '\n' + "HighScore: " + Statics.HighestScore;
        else
            txme.text = "Multipler:" + Score.multiplierScore;
    }
}
