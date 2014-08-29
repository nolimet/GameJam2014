using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public Transform enemy;
	private float time;
	private float spawnHighCounter;
	private float spawnTimer;
	private int spawnTimer2;
	private int spawnTimer3;
	private int spawnTimer4;
	public GameObject[] enemyList;

	private int corner;

<<<<<<< HEAD
=======

>>>>>>> 5d4b5e6d50a5df19bbb8c8ba97f2af49b0d60773
	void Update(){
		//print ("time" + time);
		//spawnTimer += Time.deltaTime;
		if (soundCheck.spawner == false) {
			spawnTimer = 0;
			spawnTimer2 = 0;
			spawnTimer3 = 0;
			spawnTimer4 = 0;
		} //skrillex
		if (soundCheck.spawner == true) {
			spawnTimer += 1;
			corner = 0;

			if(spawnTimer == 1)Spawn();
		} //marlyn manson
		if (soundCheck.spawner2 == true) {
			spawnTimer2 += 1;
			corner = 2;

			if(spawnTimer2 == 1)Spawn();
		} //angerfist
		if (soundCheck.spawner3 == true) {
			corner = 1;
			spawnTimer3 ++;

			if(spawnTimer3 == 1)Spawn();
		} //lil wayn
		if (soundCheck.spawner4 == true) {
			spawnTimer4 += 1;
			corner = 3;
			
			if(spawnTimer4 == 1)Spawn();
		}
		//print (spawnTimer3);
	}

	void Spawn(){
		Vector3 location = new Vector3 (-5.971444f, 4.378914f, 2f);
		Vector3 locationTwo = new Vector3 (6.042645f, 4.378914f, 0.5f);
		Vector3 locationThree = new Vector3 (5.901252f, -2.569977f, 2f);
		Vector3 locationFour = new Vector3 (-5.241997f, -2.786465f, 2f);


		if(corner == 0){
            GameObject e = Instantiate(enemyList[0], location, enemy.transform.rotation) as GameObject;
            e.transform.parent = transform;
		}
		else if(corner == 1){
            GameObject e = Instantiate(enemyList[1], locationTwo, enemy.transform.rotation) as GameObject;
            e.transform.parent = transform;
		}
		else if(corner == 2){
            GameObject e = Instantiate(enemyList[2], locationThree, enemy.transform.rotation) as GameObject;
            e.transform.parent = transform;
		}
		else if(corner == 3){
            GameObject e = Instantiate(enemyList[3], locationFour, enemy.transform.rotation) as GameObject;
            e.transform.parent = transform;
		}
            
	}
}
