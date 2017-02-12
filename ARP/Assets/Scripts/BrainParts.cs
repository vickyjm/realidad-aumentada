using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainParts : MonoBehaviour {

    public GameObject infoText, infoTitle;
    GameObject root, owner;
    // Use this for initialization
    void Start () {
        infoText.GetComponent<TextMesh>().text = "Coloca otra marca en la pantalla \npara ver informacion de las \ndistintas partes del cerebro!";
        infoTitle.GetComponent<TextMesh>().text = "Informacion";
        root = this.transform.parent.gameObject;
        owner = this.transform.GetChild(0).gameObject;
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
        GameObject parte, parte_scene;
        BoxCollider oldcollider;
        for (int i = 0; i < owner.transform.childCount; i++)
        {
            parte = owner.transform.GetChild(i).gameObject;
            parte_scene = root.transform.Find(parte.name + " Scene").gameObject;
            //scene_container = parte_scene.transform.GetChild(0).gameObject;
            parte.transform.SetParent(parte_scene.transform);
            parte.transform.position = parte_scene.transform.position;
            parte.transform.rotation = parte_scene.transform.parent.rotation;
            parte.transform.localRotation = parte.transform.parent.rotation;
            parte.transform.localEulerAngles = new Vector3(-180, 0, 0);
            oldcollider = parte.GetComponent<BoxCollider>();
            oldcollider.enabled = true;
            parte.SetActive(false);

        }
    }
}
