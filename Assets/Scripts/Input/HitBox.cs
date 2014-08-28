using UnityEngine;
using System.Collections;

public class HitBox : MonoBehaviour {

    [SerializeField]
    bool KeyPressed;
    
    [SerializeField]
    [Range(1,4)]
    int key = 1;

    void Update()
    {
        if (Input.GetAxis("key" + key) > 0.001f)
        {
            KeyPressed = true;
        }
        else
        {
            KeyPressed = false;
        }
        print(KeyPressed);
    }

	void OnTriggerEnter2d(Collision2D other){
        if (other.gameObject.tag == Statics.EnemyTag)
        {
            Score.addScore();
            Destroy(other.gameObject);
        }

    }
}
