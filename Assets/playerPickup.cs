using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerPickup : MonoBehaviour
{
    public Transform theDest;
    // public playerPickup(){
    //     Debug.Log("Let the games begin");
    // }
    //public GameObject Canvas;

    void OnMouseDown(){
        //Debug.Log("Let the games begin");
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;

    }

   
    void OnMouseUp(){
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity  = true;
    }
    //
}
