using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveScript : MonoBehaviour
{
    public GameObject cloneThis;
    // Start is called before the first frame update
    void Start()
    {
        wave(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void wave(int waveSize){
        for (int i = 0; i <= waveSize; i++)
        {
            GameObject Zclone = Instantiate(cloneThis, new Vector3(37.5f + i, 6.5f, 0), cloneThis.transform.rotation);
        }
    }
}
