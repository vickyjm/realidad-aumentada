using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainParts : MonoBehaviour {

    public GameObject infoText, infoTitle, frontalObject;
    GameObject root, owner;
    // Use this for initialization
    void Start () {
        infoTitle.GetComponent<TextMesh>().fontSize = 100;
        infoText.GetComponent<TextMesh>().text = "Coloca otra marca en la pantalla \npara ver información de las \ndistintas partes del cerebro!";
        infoTitle.GetComponent<TextMesh>().text = "Información";
        root = this.transform.parent.gameObject;
        owner = this.transform.GetChild(0).gameObject;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnMarkerTracked(ARMarker marker)
    {
        infoTitle.GetComponent<TextMesh>().fontSize = 100;
        if (marker.Tag == "cere")
        {
            infoTitle.GetComponent<TextMesh>().text = "Cerebelo";
            infoText.GetComponent<TextMesh>().text = "Es la región del encéfalo \ncuya función principal \nes de integrar las vías \nsensitivas y las \nmotoras.";
        }
        else if (marker.Tag == "kanji")
        {
            infoTitle.GetComponent<TextMesh>().text = "Parietal";
            infoText.GetComponent<TextMesh>().text = "El lóbulo parietal es la parte del \nestá encargado de recibir \nsensaciones de tacto, calor \nfrío, presión, dolor y \ncoordinar el equilibrio.";
        }
        else if (marker.Tag == "fron")
        {
            if (frontalObject.transform.GetChildCount() == 5)
            {
                infoTitle.GetComponent<TextMesh>().text = "Cerebro";
                infoText.GetComponent<TextMesh>().text = "Se encarga de procesar \ninformación sensorial, controla \ny coordina el movimiento \nel comportamiento y los \nsentimientos.";
            }
            else
            {
                infoTitle.GetComponent<TextMesh>().text = "Frontal";
                infoText.GetComponent<TextMesh>().text = "El lóbulo frontal se \nencarga de la producción \nlingüística y oral.";
            }
        }
        else if (marker.Tag == "occ")
        {
            infoTitle.GetComponent<TextMesh>().text = "Occipital";
            infoText.GetComponent<TextMesh>().text = "El lóbulo occipital se \nencarga de recibir \ninformación visual y \nenviarla a otras zonas \ncerebrales que la \nprocesan.";
        }
        else if (marker.Tag == "temp")
        {
            infoTitle.GetComponent<TextMesh>().text = "Temporal";
            infoText.GetComponent<TextMesh>().text = "El lóbulo temporal se \nencarga de recibir y \nprocesar información procedente \nde los oídos, contribuye al \nequilibrio y regula \nciertas emociones.";
        }
        else if (marker.Tag == "unai")
        {
            infoTitle.GetComponent<TextMesh>().fontSize = 65;
            infoTitle.GetComponent<TextMesh>().text = "Tronco del encéfalo";
            infoText.GetComponent<TextMesh>().text = "El tronco del encéfalo es \nla mayor ruta que comunica el \ncerebro anterior, la médula \nespinal y los nervios periféricos. \nTambién controla la respiración y \nel ritmo cardíaco.";
        }
    }

    void OnMarkerLost(ARMarker marker)
    {
        infoTitle.GetComponent<TextMesh>().fontSize = 100;
        infoText.GetComponent<TextMesh>().text = "Coloca otra marca en la pantalla \npara ver información de las \ndistintas partes del cerebro!";
        infoTitle.GetComponent<TextMesh>().text = "Información";
        Debug.Log(marker.name + " Se fue");
        GameObject parte, parte_scene;
        BoxCollider oldcollider;
        int i = 0;
        while (owner.transform.childCount!=0)
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
