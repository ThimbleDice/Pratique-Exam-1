using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang : MonoBehaviour {

    [SerializeField] public GameObject BangText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Jump") > 0)
        {
            Instantiate(BangText);
        }
    }
}