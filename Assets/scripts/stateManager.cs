using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateManager : MonoBehaviour {
    private int score = 0;
    public GameObject physicsObjectPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // our spawn method
    public void spawnPhysicsObject(){
        print("in spawnPhysicsObject");
        Instantiate(physicsObjectPrefab, GameObject.Find("spawnPoint").transform);
    } // end spawnPhysicsObject

    public void goal(){
        score++;
        print("score: " + score);
    } // end goal
} // end class
