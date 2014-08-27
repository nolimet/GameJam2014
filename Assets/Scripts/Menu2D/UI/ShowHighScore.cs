using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TextMesh))]
public class ShowHighScore : MonoBehaviour {

    TextMesh txm;
    void Start()
    {
       txm =  GetComponent<TextMesh>();
    }

    void Update()
    {
        if (Statics.HighestScore > 0)
            txm.text = "HighScore: " + Statics.HighestScore;
        else
            txm.text = "HighScore: Play a round";
        
        

    }
}
