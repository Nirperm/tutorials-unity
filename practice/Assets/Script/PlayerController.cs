using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    private GameObject rigidbodySource;

    public float speed = 10;

	// Use this for initialization
	//void Start () {

	//}

	// Update is called once per frame
	//void Update () {

	//}

    private void FixedUpdate(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");       

        // 同一のGameObjectが持つRigidbodyコンポーネントを取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // rigidbodyのx軸（横）とz軸（奥）に力を加える
        rigidbody.AddForce(x * speed, 0, z * speed);
	}
}

