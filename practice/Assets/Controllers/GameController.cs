using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text scoreLabel;
    [SerializeField]
    private GameObject winnerLabelObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        if (count == 0) {
            winnerLabelObject.SetActive(true);
        }
    }
}
