using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class placeScript : MonoBehaviour
{
    public skullScript sklScript;
    public GameObject skullController;
    public GameObject towerRight;
    public GameObject towerLeft;
    public GameObject towerMainL;
    public GameObject towerMainR;
    public Toggle left;
    public Toggle right;
    public Toggle mainL;
    public Toggle mainR;
    public void placeBtn(string x = ""){
        if(left.isOn){
            if(sklScript.points >= 200){
                towerLeft.SetActive(true);
                skullController.GetComponent<skullScript>().skullCount(sklScript.points - 200);
            }
            else{
                Debug.Log("not enough money");
            }
        }
        else{
            towerLeft.SetActive(false);
        }
        if(right.isOn){
            if(sklScript.points >= 200){
                towerRight.SetActive(true);
                skullController.GetComponent<skullScript>().skullCount(sklScript.points - 200);
            }
            else{
                Debug.Log("not enough money");
            }
        }
        else{
            towerRight.SetActive(false);
        }
        if(mainL.isOn){
            if(sklScript.points >= 200){
                towerMainL.SetActive(true);
                skullController.GetComponent<skullScript>().skullCount(sklScript.points - 200);
            }
            else{
                Debug.Log("not enough money");
            }
        }
        else{
            towerMainL.SetActive(false);
        }
        if(mainR.isOn){
            if(sklScript.points >= 200){
                towerMainR.SetActive(true);
                skullController.GetComponent<skullScript>().skullCount(sklScript.points - 200);
            }
            else{
                Debug.Log("not enough money");
            }
        }
        else{
            towerMainR.SetActive(false);
        }
    }
       // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0)) {  
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
    //         RaycastHit hit;  
    //         if (Physics.Raycast(ray, out hit)) {  
    //             if (hit.transform.name == "frontRight") {  
    //                 Debug.Log("tower placed");
    //                 towerRight.SetActive(true);
    //                 Vector3 up = transform.TransformDirection(Vector3.up) * 15;
    //                 Debug.DrawRay(transform.position, up, Color.green);
    //             }  
    //             if (hit.transform.name == "frontLeft") {  
    //                 Debug.Log("tower placed");
    //                 towerLeft.SetActive(true);
    //                 Vector3 up = transform.TransformDirection(Vector3.up) * 15;
    //                 Debug.DrawRay(transform.position, up, Color.green);
    //             } 
    //             if (hit.transform.name == "mainright") {  
    //                 Debug.Log("tower placed");
    //                 towerMainR.SetActive(true);
    //                 Vector3 up = transform.TransformDirection(Vector3.up) * 15;
    //                 Debug.DrawRay(transform.position, up, Color.green);
    //             } 
    //             if (hit.transform.name == "mainLeft") {  
    //                 Debug.Log("tower placed");
    //                 towerMainL.SetActive(true);
    //                 Vector3 up = transform.TransformDirection(Vector3.up) * 15;
    //                 Debug.DrawRay(transform.position, up, Color.green);
    //             } 
    //         }  
    //     }  
    // }
}
