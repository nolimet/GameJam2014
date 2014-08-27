using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public Transform enemy;
	
	public GameObject[] enemyList;

	private int corner;

	void Update(){
		if (soundCheck.spawner == false) {
			corner = Random.Range(0, 4);
			Spawn();		
		}
	}

	void Spawn(){
		Vector3 location = new Vector3 (-5.971444f, 4.378914f, 2f);
		Vector3 locationTwo = new Vector3 (6.042645f, 4.378914f, 2f);
		Vector3 locationThree = new Vector3 (6.042645f, -4.329527f, 2f);
		Vector3 locationFour = new Vector3 (-5.971444f, -4.329527f, 2f);

		if(corner == 0){
			Instantiate (enemyList[0], location, enemy.transform.rotation);
		}
		else if(corner == 1){
			Instantiate (enemyList[1], locationTwo, enemy.transform.rotation);
		}
		else if(corner == 2){
			Instantiate (enemyList[2], locationThree, enemy.transform.rotation);
		}
		else if(corner == 3){
			Instantiate (enemyList[3], locationFour, enemy.transform.rotation);
		}
	}
}
