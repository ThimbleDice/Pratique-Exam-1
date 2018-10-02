using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BangAnimation : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        GetComponent<Text>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
