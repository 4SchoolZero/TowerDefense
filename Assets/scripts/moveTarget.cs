using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTarget : MonoBehaviour
{
    public Transform[] targets;
    private int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= targets.Length; i++)
        {
            var step =  1.5f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targets[x].position, step);
            if (Vector3.Distance(transform.position, targets[x].position) < 2)
            {
                //targets[x].position *= -1.0f;
                x++;
                Debug.Log(x);
            }
            if(x >= targets.Length) x = 0;
        }
    }
}
