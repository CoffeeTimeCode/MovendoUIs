﻿using UnityEngine;
using System.Collections;

public class MovimentarUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MoverUI(){
		this.transform.position = new Vector3 (Input.mousePosition.x,Input.mousePosition.y,0);
	}
}
