using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	void Start () {
		transform.position = new Vector3(Random.Range(-0.75f, 0.75f), Random.Range(0.25f, 1.5f),5.36f);
	}
	

	void FixedUpdate () {
		transform.Translate(0,0,-0.02f);
	}

	void OnCollisionEnter (Collision col) {
		Debug.Log("collision");
		if (col.gameObject.name == "shield") {
			Debug.Log("shield");
			Destroy(gameObject);
		}
	}
}