using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public Transform enemy;
	private float time;
	private float spawnHighCounter;
	private int spawnTimer;
	public GameObject[] enemyList;

	private int corner;

	void Update(){
		time += Time.deltaTime;
		if (time >= 30) {
			spawnHighCounter = 9;		
		}
		if (soundCheck.spawner == true) {
			spawnTimer += 1;
			corner = 0;

			if(spawnTimer >= 4)
				Spawn();
		}
		if (soundCheck.spawner2 == true) {
			spawnTimer += 1;
			corner = 1;
			
			if(spawnTimer >= 4)
				Spawn();
		}
		if (soundCheck.spawner3 == true) {
			spawnTimer += 1;
			corner = 2;

			if(spawnTimer >= 4)
				Spawn();
		}
		if (soundCheck.spawner4 == true) {
			spawnTimer += 1;
			corner = 3;
			
			if(spawnTimer >= spawnHighCounter)
				Spawn();
		}
	}

	void Spawn(){
		spawnTimer = 0;
		Vector3 location = new Vector3 (-5.971444f, 4.378914f, 2f);
		Vector3 locationTwo = new Vector3 (6.042645f, 4.378914f, 2f);
		Vector3 locationThree = new Vector3 (5.901252f, -2.569977f, 2f);
		Vector3 locationFour = new Vector3 (-5.241997f, -2.786465f, 2f);

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
