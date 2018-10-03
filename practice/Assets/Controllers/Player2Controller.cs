using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {
	// Use this for initialization
    protected float jump_seed = 5.0f;
    protected bool is_landing = false;

    private Rigidbody rb;

    void Awake() {
        rb = this.GetComponent<Rigidbody>();
    }

	void Start () {
        this.is_landing = false;		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.is_landing) {
            if (Input.GetMouseButtonDown(0)) {
                this.is_landing = false;
                rb.velocity = Vector3.up * this.jump_seed;
            }
        } 
	}

	private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ground"){
            this.is_landing = true;
        } 
	}
}
