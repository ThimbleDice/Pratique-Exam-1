using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {

    [SerializeField] public float planeMaxSpeed = 10;
    [SerializeField] public GameObject propeller;
    [SerializeField] public ParticleSystem smoke;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        InputManager();
    }

    private void InputManager()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            print("Touriste");
            MouveForward(planeMaxSpeed * Input.GetAxis("Jump") * Time.deltaTime);
            TurnPropeller(planeMaxSpeed * Input.GetAxis("Jump") * Time.deltaTime);
        }
        else
            smoke.Play();
    }

    private void MouveForward(float force)
    {
        GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(force,0,0), new Vector3(1,0,0));
        GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(0,force,0), new Vector3(0,0,0));
    }

    private void TurnPropeller(float speed)
    {
        propeller.transform.Rotate(new Vector3(speed, 0,0));
    }
}
