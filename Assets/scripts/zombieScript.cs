using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieScript : MonoBehaviour
{
    public Transform[] targets;
    private Animator anim;
    public GameObject cloneThis;
    private int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        clone(5);
    }
    // Update is called once per frame
    void Update()
    {
        walkTo();
    }
    void clone(int waveSize){
        for (int i = 0; i < waveSize; i++)
        {
              Instantiate(cloneThis);
              Debug.Log("spawn");
        }
    }
    void walkTo(){
        for (int i = 0; i <= targets.Length; i++)
        {
            var step =  1.5f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targets[x].position, step);
            if (Vector3.Distance(transform.position, targets[x].position) < 2)
            {
                x++;
                Debug.Log(x);
            }
            if(x >= targets.Length) x = 0;
        }
    }
}
