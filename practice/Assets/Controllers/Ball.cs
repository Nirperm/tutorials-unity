using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Rigidbody rb;
    protected bool is_visibe = true;


    void Awake() {
        rb = this.GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start () {
        rb.velocity = new Vector3(-8.0f, 8.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnBecameInvisible(){
        Destroy(this.gameObject);
	}
}
