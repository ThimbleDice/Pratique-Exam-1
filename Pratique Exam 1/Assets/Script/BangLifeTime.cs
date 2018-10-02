using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangLifeTime : MonoBehaviour {

    private float timeLeft;

    // Use this for initialization
    void Start () {
        timeLeft = 2;
    }
	
	// Update is called once per frame
	void Update () {
        if (timeLeft > 0)
            timeLeft -= Time.deltaTime;
        else
            Destroy(gameObject);
    }
}
