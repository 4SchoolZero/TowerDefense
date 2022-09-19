using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierScript : MonoBehaviour
{
    public Transform target; 
    public Animation anim;   
    void Start()
    {
        
    }
    void track(){
        float distance = Vector3.Distance(target.position, transform.position);
        Debug.Log(distance);
        while(distance < 15){
            transform.LookAt(target);
            anim.Play("demo_combat_shoot");
        }
    }
    // Update is called once per frame
    void Update()
    {
        track();
    }
}
