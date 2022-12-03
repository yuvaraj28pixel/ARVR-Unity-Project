using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenModal : MonoBehaviour
{
    public GameObject Canvas;
    void OnMouseOver(){
        if(Input.GetMouseButtonDown(1)){
            if(!Canvas.active){
                Canvas.SetActive(true);
                Debug.Log("Let the games begin");
            } else {
                Canvas.SetActive(false);
                Debug.Log("Let the games end");
            }
        }

        
    }
}
