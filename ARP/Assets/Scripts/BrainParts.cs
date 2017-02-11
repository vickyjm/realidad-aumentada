using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainParts : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMarkerLost(ARMarker marker)
    {
        Debug.Log(marker.name + " Se fue");
        //this.transform.position = this.transform.parent.parent.position;
    }
}
