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
        anim = GetComponent<Animator>();
        anim.Play("idle");
    }
    public void shoot(int dmg){
        var x = GameObject.FindWithTag("Zombie");
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance < 15){
            transform.LookAt(target);
            anim.Play("shoot");
            healthZombie = healthZombie - dmg;
            if(healthZombie <= 0){
                Destroy(x);
            }
        }
        else{
            transform.LookAt(Vector3.back);
            anim.Play("idle");
        }
    }
    // Update is called once per frame
    void Update()
    {
        shoot(20);
    }
}
