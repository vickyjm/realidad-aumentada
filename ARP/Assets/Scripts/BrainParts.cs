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
        infoText.GetComponent<TextMesh>().text = "Coloca otra marca en la pantalla \npara ver informacion de las \ndistintas partes del cerebro!";
        infoTitle.GetComponent<TextMesh>().text = "Informacion";
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnMarkerTracked(ARMarker marker)
    {
        if (marker.Tag == "cere")
        {
            infoTitle.GetComponent<TextMesh>().text = "Cerebelo";
            infoText.GetComponent<TextMesh>().text = "El cerebelo es la parte del \ncerebro encargada de...";
        }
        else if (marker.Tag == "kanji")
        {
            infoTitle.GetComponent<TextMesh>().text = "Parietal";
            infoText.GetComponent<TextMesh>().text = "El lobulo parietal es la parte del \ncerebro encargada de...";
        }
        else if (marker.Tag == "fron")
        {
            infoTitle.GetComponent<TextMesh>().text = "Frontal";
            infoText.GetComponent<TextMesh>().text = "El lobulo frontal es la parte del \ncerebro encargada de...";
        }
        else if (marker.Tag == "occ")
        {
            infoTitle.GetComponent<TextMesh>().text = "Occipital";
            infoText.GetComponent<TextMesh>().text = "El lobulo occipital es la parte del \ncerebro encargada de...";
        }
        else if (marker.Tag == "temp")
        {
            infoTitle.GetComponent<TextMesh>().text = "Temporal";
            infoText.GetComponent<TextMesh>().text = "El lobulo temporal es la parte del \ncerebro encargada de...";
        }
        else if (marker.Tag == "unai")
        {
            infoTitle.GetComponent<TextMesh>().text = "Tronco del encefalo";
            infoText.GetComponent<TextMesh>().text = "El tronco del encefalo es la parte del \ncerebro encargada de...";
        }
    }

    void OnMarkerLost(ARMarker marker)
    {
        infoText.GetComponent<TextMesh>().text = "Coloca otra marca en la pantalla \npara ver informacion de las \ndistintas partes del cerebro!";
        infoTitle.GetComponent<TextMesh>().text = "Informacion";
        Debug.Log(marker.name + " Se fue");
        //this.transform.position = this.transform.parent.parent.position;
    }
}
