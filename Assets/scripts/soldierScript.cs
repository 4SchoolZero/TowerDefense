using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierScript : MonoBehaviour
{
    public Transform target;
    public GameObject pow;
    private Animator anim;
    public string targetTag = "zombie";
    public float range = 20f;

   
    void Start()
    {
        anim = GetComponent<Animator>();
        
        anim.Play("idle");
        InvokeRepeating("track", 0f, 0.5f);
    }
    void Update()
    {
        if(target == null){
            return;
        }
        Vector3 direction = target.position - transform.position;
        Quaternion look = Quaternion.LookRotation(direction);
        Vector3 rot = look.eulerAngles;
        transform.rotation = look;
        Debug.DrawRay(transform.position, transform.forward * 15, Color.green);
    }
     void track(){
        GameObject[] targets = GameObject.FindGameObjectsWithTag(targetTag); 
        float minDist = Mathf.Infinity;
        GameObject cloDist = null;
        foreach(GameObject enemy in targets){
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if(distance < minDist){
                minDist = distance;
                cloDist = enemy;
            }
        }
        if (cloDist != null && minDist <= range){
            target = cloDist.transform;
            anim.Play("shoot");
            pow.SetActive(true);
            Destroy(cloDist, 2);
            
        }
        else{
            target = null;
            anim.Play("idle");
            pow.SetActive(false);
        }
    }
}
