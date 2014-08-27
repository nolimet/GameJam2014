using UnityEngine;
using System.Collections;

public class SaveManager : MonoBehaviour
{

    string highScore = "highScore";
#if UNITY_EDITOR
    [SerializeField]
    int HighScore = 0;
#endif
    void Start()
    {
        Statics.HighestScore = PlayerPrefs.GetInt(highScore);

        #if UNITY_EDITOR
        HighScore = Statics.HighestScore;
        #endif

        DontDestroyOnLoad(this);

        Application.LoadLevel(1);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt(highScore, Statics.HighestScore);

        PlayerPrefs.Save();
    }
#if UNITY_EDITOR
    void Update()
    {
        Statics.HighestScore = HighScore;
    }
#endif
}
