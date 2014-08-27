using UnityEngine;
using System.Collections;

public class SaveManager : MonoBehaviour
{

    string highScore = "highScore";

    [SerializeField]
    int HighScore = 0;
    void Start()
    {
        Statics.HighestScore = PlayerPrefs.GetInt(highScore);
        HighScore = Statics.HighestScore;

        DontDestroyOnLoad(this);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt(highScore, Statics.HighestScore);

        PlayerPrefs.Save();
    }
    void Update()
    {
        Statics.HighestScore = HighScore;
    }
}
