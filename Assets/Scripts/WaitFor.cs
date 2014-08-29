using UnityEngine;
using System.Collections;

public class WaitFor : MonoBehaviour {

    [SerializeField]
	float WaitTime = 3f;

    Animator ani;
    void Start(){
        ani = GetComponent<Animator>();
        ani.enabled = false;

    }


	void Update () {
        WaitTime -= Time.deltaTime;
        if (WaitTime <= 0f)
        {
            ani.enabled = true;
            Destroy(this);
        }
	}
}
