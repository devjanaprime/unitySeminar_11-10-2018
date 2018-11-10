using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        print("entered trigger: " + other.tag);
    }

    private void OnTriggerExit(Collider other)
    {
        print("exited trigger: " + other.tag);
    }
}
