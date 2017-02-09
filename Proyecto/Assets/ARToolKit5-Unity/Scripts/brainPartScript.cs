using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainPartScript : MonoBehaviour {

    public GameObject infoText;
    public string currentMarkName;

    // Use this for initialization
    void Start () {
        infoText = GameObject.FindWithTag("infoText");
        //targetRotation = otherMark.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        //otherMark.transform.rotation = Quaternion.Lerp(otherMark.transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
	}

    void OnMarkerTracked(ARMarker marker)
    {
        if (marker.Tag == "cerebeloMark")
            infoText.GetComponent<TextMesh>().text = "Cerebelo";
        else if (marker.Tag == "parietalMark")
            infoText.GetComponent<TextMesh>().text = "Parietal";
        else if (marker.Tag == "frontalMark")
            infoText.GetComponent<TextMesh>().text = "Frontal";
        else if (marker.Tag == "occipitalMark")
            infoText.GetComponent<TextMesh>().text = "Occipital";
        else if (marker.Tag == "temporalMark")
            infoText.GetComponent<TextMesh>().text = "Temporal";
    }

    void OnMarkerLost(ARMarker marker)
    {
        infoText.GetComponent<TextMesh>().text = "i";
    }
}
