using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D player){
		if (player.gameObject.tag == "Enemy")
		{
			Destroy(player.gameObject);	
		}
	}
}
