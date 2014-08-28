using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D enemy){
		if (enemy.gameObject.tag == "Low")
		{
			if(Input.GetKey(KeyCode.Z)){
				print("haha");
				Destroy(this.gameObject);	
			}
		}
		if (enemy.gameObject.tag == "Mid")
		{
			if(Input.GetKey(KeyCode.X)){
				print("haha");
				Destroy(this.gameObject);	
			}
		}
		if (enemy.gameObject.tag == "MidTwo")
		{
			if(Input.GetKey(KeyCode.C)){
				print("haha");
				Destroy(this.gameObject);	
			}
		}
		if (enemy.gameObject.tag == "High")
		{
			if(Input.GetKey(KeyCode.V)){
				print("haha");
				Destroy(this.gameObject);	
			}	
		}
	}
}
