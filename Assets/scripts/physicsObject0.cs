using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsObject0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update ()
    {
        // fall off world?
        if (transform.position.y < -100)
        {
            Camera.main.SendMessage("spawnPhysicsObject");
            Destroy(gameObject);
        } // fell too far
        print(Random.Range(0, 100));
    }

    private void OnCollisionEnter(Collision collision)
    {  
        // Goal?
        if( collision.collider.tag == "Goal"){
            // increment score
            print("Goal");
            // delete this object
            Camera.main.SendMessage("spawnPhysicsObject");
            Camera.main.SendMessage("goal");
            Destroy(gameObject);
        } // end Goal
        if( collision.collider.tag == "Player" ){
            GetComponent<Rigidbody>().AddForce(0, 50, 0);
        } // end Player
    } // end OnCollisionEnter
} // end class
