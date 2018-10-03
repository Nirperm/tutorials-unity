using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	// トリガーとの接触時に呼ばれるコールバック
    private void OnTriggerEnter(Collider hit){
        if (hit.CompareTag("Player")) {

            // このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);
        }   
	}
}
