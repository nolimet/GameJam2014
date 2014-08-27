using UnityEngine;
using System.Collections;

public class movementEnemy : MonoBehaviour {

	public Transform target; // drag the player here
	public float speed = 5.0f; // move speed

	void Update(){
		transform.position = Vector3.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
		}

}
