using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow2Axes : MonoBehaviour {
	
	public GameObject controller;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(controller.transform.position.x, controller.transform.position.y, 1.2f);
	}
}
