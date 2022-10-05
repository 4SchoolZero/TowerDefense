using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {  
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {  
                if (hit.transform.name == "defensePlatformFrontRight") {  
                    Debug.Log("tower placed");
                    Vector3 up = transform.TransformDirection(Vector3.up) * 15;
                    Debug.DrawRay(transform.position, up, Color.green);
                }  
            }  
        }  
    }
}
