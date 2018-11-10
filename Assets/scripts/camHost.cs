using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camHost : MonoBehaviour {
    // to what are we going to be attached
    public Transform ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // move this object to our ball's position
        transform.position = ball.position;
        // mouse look
        transform.Rotate(0, Input.GetAxis( "Mouse X" ) * 5.0f * Time.fixedTime, 0);
	}
}
