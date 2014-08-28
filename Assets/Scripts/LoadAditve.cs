using UnityEngine;
using System.Collections;

public class LoadAditve : MonoBehaviour {

    [SerializeField]
    string toLoad;
	// Use this for initialization
	void Start () 
    {
        Application.LoadLevelAdditive(toLoad);
	}
}
