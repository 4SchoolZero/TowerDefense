using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierScript : MonoBehaviour
{
    [SerializeField]private Transform target; 
    [SerializeField]private Animator anim;
    int healthZombie = 100;
    
    void Start()
    {
        StartCoroutine(test());
        anim = GetComponent<Animator>();
        anim.Play("idle");
    }
    public void dmg(int dmg){
        var x = GameObject.FindWithTag("Zombie");
        healthZombie = healthZombie - dmg;
        anim.Play("shoot");
        if(healthZombie <= 0){
            Destroy(x);
        }
    }
    public void shoot(){
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance < 10){
            transform.LookAt(target);
        }
        else{
            anim.Play("idle");
        }
    }
    IEnumerator test(){
        shoot();
        yield return new WaitForSeconds(1);
        dmg(20);
    }
    void Update()
    {
        
    }
}
