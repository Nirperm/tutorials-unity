﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {
    [SerializeField]
    private GameObject ball;
    protected bool is_landing = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(1)) {
            Instantiate(this.ball);
        }
	}
}
