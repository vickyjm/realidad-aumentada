using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideController : MonoBehaviour {
    Vector3 posother,myposition,diff,tamanho;
    GameObject wrapper;
    BoxCollider boxwrap,minebox;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision other)
    {
        posother = other.transform.position;
        myposition = this.transform.position;

        Debug.Log(other.collider.name + " Dentro");
        if( System.Int32.Parse(this.tag) < System.Int32.Parse(other.gameObject.tag) ){
            //wrapper = new GameObject();
            //wrapper.transform.SetParent(this.transform.parent);
            //wrapper.AddComponent<BoxCollider>();
            //wrapper.transform.position = this.transform.position;
            boxwrap = this.GetComponent<BoxCollider>();
            boxwrap.size = new Vector3(2.25f, 3.0f, 2.5f);
            
        }
        else
        {
            boxwrap = this.GetComponent<BoxCollider>();
            boxwrap.enabled = false;
            this.transform.SetParent(other.gameObject.transform.parent);
            this.transform.position = other.transform.position;
            this.transform.rotation = other.transform.rotation;

        }
        //wrapper = new GameObject();
        //wrapper.AddComponent<BoxCollider>();
        //boxwrap = wrapper.GetComponent<BoxCollider>();

        //
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log(other.collider.name + " Sale");
        //Destruir el grande
        if (System.Int32.Parse(this.tag) < System.Int32.Parse(other.gameObject.tag))
        {
            boxwrap = new BoxCollider();
        }
        //this.gameObject.AddComponent<BoxCollider>();
        //this.transform.position = this.transform.parent.parent.position;
    }
    private void OnCollisionStay(Collision collision)
    {
        //collisin
    }

}
