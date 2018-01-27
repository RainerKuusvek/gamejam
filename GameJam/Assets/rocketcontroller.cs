using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketcontroller : MonoBehaviour {
    public Transform southeast, southwest, northeast, northwest;
    Rigidbody rigidbod;
    public float magnitude;
    void Start () {
        rigidbod = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
        if (Input.GetKey(KeyCode.D))
        {
            rigidbod.AddForceAtPosition(-southeast.forward*magnitude, southeast.position);

        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbod.AddForceAtPosition(-southwest.forward * magnitude, southwest.position);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigidbod.AddForceAtPosition(-northwest.forward * magnitude, northwest.position);

        }

    }
}
