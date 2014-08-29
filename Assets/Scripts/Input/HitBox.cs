using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]
public class HitBox : MonoBehaviour {

    [SerializeField]
    bool[] KeyPressed;

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

	void OnTriggerEnter2D(Collider2D other){
        for (int i = 0; i <= 3; i++)
        {
            if (KeyPressed[i] == true && other.tag == Statics.EnemyTag && other.name == "Enemy " + i + "(Clone)")
            {
                Debug.Log("Bonk");
                if (Vector3.Distance(transform.position, other.transform.position) > 2)
                {
                    Score.addScore();
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
