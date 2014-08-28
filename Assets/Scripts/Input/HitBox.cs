using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]
public class HitBox : MonoBehaviour {

    [SerializeField]
    bool[] KeyPressed;
    
    [SerializeField]
    [Range(1,4)]
    int key = 1;

    void Start()
    {
        KeyPressed = new bool[4];
    }

    void Update()
    {
        for (int i = 0; i <= 3; i++)
        {
            if (Input.GetAxis("key" + (i+1)) > 0.001f)
            {
                KeyPressed[i] = true;
            }
            else
            {
                KeyPressed[i] = false;
            }
            print(i + ":" + KeyPressed[i]);
        }
    }

	void OnTriggerEnter2d(Collision2D other){
        for (int i = 0; i <= 3; i++)
        {
            if (KeyPressed[i] && other.gameObject.tag == Statics.EnemyTag && other.gameObject.name == "Enemy " + i)
            {
                Score.addScore();
                Destroy(other.gameObject);
            }
        }
    }
}
