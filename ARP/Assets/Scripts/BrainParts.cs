using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainParts : MonoBehaviour {

    public GameObject infoText;
    public GameObject infoTitle;
    // Use this for initialization
    void Start () {
        infoText = GameObject.FindWithTag("infoText");
        infoTitle = GameObject.FindWithTag("infoTitle");
        infoText.GetComponent<TextMesh>().text = "i";
        infoTitle.GetComponent<TextMesh>().text = "";
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnMarkerTracked(ARMarker marker)
    {
        if (marker.Tag == "cere")
            infoTitle.GetComponent<TextMesh>().text = "Cerebelo";
        else if (marker.Tag == "kanji")
            infoTitle.GetComponent<TextMesh>().text = "Parietal";
        else if (marker.Tag == "fron")
            infoTitle.GetComponent<TextMesh>().text = "Frontal";
        else if (marker.Tag == "occ")
            infoTitle.GetComponent<TextMesh>().text = "Occipital";
        else if (marker.Tag == "temp")
            infoTitle.GetComponent<TextMesh>().text = "Temporal";
        else if (marker.Tag == "unai")
            infoTitle.GetComponent<TextMesh>().text = "Stem";
    }

    void OnMarkerLost(ARMarker marker)
    {
        //infoText.GetComponent<TextMesh>().text = "i";
        infoTitle.GetComponent<TextMesh>().text = "";
        Debug.Log(marker.name + " Se fue");
        //this.transform.position = this.transform.parent.parent.position;
    }
}
