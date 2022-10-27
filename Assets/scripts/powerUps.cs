using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUps : MonoBehaviour
{
    public skullScript sklScript;
    public GameObject skullController;
    public GameObject muzzle;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void turret(){
        if(sklScript.points >= 400){
            GameObject[] targets = GameObject.FindGameObjectsWithTag("Zombie"); 
            muzzle.SetActive(true);
            for (var i = 0; i < targets.Length; i++) {
                Destroy(targets[i].gameObject, 3);
            }
           skullController.GetComponent<skullScript>().skullCount(sklScript.points - 400); 
        }
        else{
            Debug.Log("no turret");
        }
    }
    public void nuke(){
        if(sklScript.points >= 500){
            GameObject[] targets = GameObject.FindGameObjectsWithTag("Zombie"); 
            for (var i = 0; i < targets.Length; i++) {
                Destroy(targets[i]);
            }
            skullController.GetComponent<skullScript>().skullCount(sklScript.points - 500);
        }
        else{
            Debug.Log("no nuke");
        }
    }
}
