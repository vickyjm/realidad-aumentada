using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomScript : MonoBehaviour {

    public float smooth = 1f;
    private Quaternion targetRotation;
    public GameObject otherMark;

    // Use this for initialization
    void Start () {
        otherMark = GameObject.FindWithTag("male0");
        targetRotation = otherMark.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        otherMark.transform.rotation = Quaternion.Lerp(otherMark.transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
	}

    void OnMarkerTracked(ARMarker marker)
    {
        if (otherMark != null)
        {
            targetRotation *= Quaternion.AngleAxis(60, Vector3.up);
        }
    }
}
