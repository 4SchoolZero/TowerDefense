using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUps : MonoBehaviour
{
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
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Zombie"); 
        muzzle.SetActive(true);
        for (var i = 0; i < targets.Length; i++) {
            Destroy(targets[i].gameObject, 3);
        }
    }
    public void nuke(){
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Zombie"); 
        for (var i = 0; i < targets.Length; i++) {
            Destroy(targets[i]);
        }
    }
}
