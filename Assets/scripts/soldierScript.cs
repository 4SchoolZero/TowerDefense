using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierScript : MonoBehaviour
{
    [SerializeField]private GameObject target;
    [SerializeField]private Animator anim;
    [SerializeField]public GameObject pow;

    int healthZombie = 100;
     public void dmg(){
        healthZombie = healthZombie - 1;
        if(healthZombie <= 0){
            Destroy(target);
            pow.SetActive(false);
        }
    }
    public void track(){
        var y = target.transform;
        float distance = Vector3.Distance(y.position, transform.position);
        if(distance < 13){
            transform.LookAt(y);
            anim.Play("shoot");
            pow.SetActive(true);
            InvokeRepeating("dmg", 4f, 2f);
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("idle");
    }
    void Update()
    {
        track();
    }
}
