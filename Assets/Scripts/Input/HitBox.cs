using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]
public class HitBox : MonoBehaviour {

    [SerializeField]
    bool[] KeyPressed;
    float[] KeyPressedTime;

    void Start()
    {
        KeyPressed = new bool[4];
        KeyPressedTime = new float[4];
    }

    void Update()
    {
        for (int i = 0; i <= 3; i++)
        {
            if (Input.GetAxis("key" + (i+1)) > 0.001f)
            {
                KeyPressed[i] = true;

                KeyPressedTime[i] += Time.deltaTime;
            }
            else
            {
                KeyPressed[i] = false;
                KeyPressedTime[i] = 0;
            }
            if (KeyPressedTime[0] > 0.4f)
                Score.mistake();
        }
    }

	void OnTriggerEnter2D(Collider2D other){
        for (int i = 0; i <= 3; i++)
        {
            if (KeyPressed[i] == true && other.tag == Statics.EnemyTag && other.name == "Enemy " + i + "(Clone)")
            {
                if (Vector3.Distance(transform.position, other.transform.position) > 2)
                {
                    KeyPressedTime[0] = 0;
                    Score.addScore();
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
