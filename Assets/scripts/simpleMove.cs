using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMove : MonoBehaviour {
    // move speed
    private float moveSpeed = 3.9f;
    private float turnSpeed = 900.0f;
	// Use this for initialization
	void Start () {
		
	} // end Start
	
	// Update is called once per frame
	void Update () {
        // don't forget to scale based on Time
        // rotate left/right based on mouse axis
        transform.Rotate(0, Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime, 0);
        // forward on W
        if( Input.GetKey( "w" ) || Input.GetKey("up") )
        {
            transform.Translate( transform.forward * moveSpeed * Time.fixedDeltaTime );
        } //end w
        // back on s
        if( Input.GetKey( "s") || Input.GetKey("down"))
        {
            transform.Translate( transform.forward * -moveSpeed * Time.fixedDeltaTime );
        }
        // left on a
        if (Input.GetKey("a") || Input.GetKey("left") )
        {
            transform.Translate( transform.right * -moveSpeed * Time.fixedDeltaTime );
        }
        // right on d
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.Translate(transform.right * moveSpeed * Time.fixedDeltaTime);
        }
    } // end Update
} // end Class
