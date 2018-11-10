using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsObject0 : MonoBehaviour {
    private string lastCollidedWith = "";
    private int juggle = 0;
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
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Goal?
        if ( collision.collider.tag == "Goal"){
            // increment score
            print("Goal");
            // delete this object
            Camera.main.SendMessage("spawnPhysicsObject");
            Camera.main.SendMessage("spawnPhysicsObject");
            Camera.main.SendMessage("spawnPhysicsObject");
            Camera.main.SendMessage("goal");
            Destroy(gameObject);
        } // end Goal
        if( collision.collider.tag == "Player" ){
            GetComponent<Rigidbody>().AddForce(0, collision.collider.transform.localScale.x * 50, 0);
            if(lastCollidedWith == "Player"){
                juggle++;
                if( juggle >1){
                    collision.collider.transform.localScale = new Vector3(collision.collider.transform.localScale.x * 1.1f, collision.collider.transform.localScale.y * 1.1f, collision.collider.transform.localScale.z * 1.1f);
                } //end scale up for juggle
            } // end player juggle
            else{
                juggle = 0;
            } // end juggle
        } // end Player
        lastCollidedWith = collision.collider.tag;
    } // end OnCollisionEnter
} // end class
