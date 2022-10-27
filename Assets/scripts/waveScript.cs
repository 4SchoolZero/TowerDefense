using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveScript : MonoBehaviour
{
    public skullScript sklScript;
    public GameObject cloneThis;
    public GameObject skullController;
    public Text waveCount;
    public int speed = 0;
    public int startWave = 6;
    bool oneTime;
    
    // Start is called before the first frame update
    void Start()
    {
        wave(startWave);
    }

    // Update is called once per frame
    void Update()
    {
        waveCalc();
    }
    void waveCalc(){
        int x = 0;
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Zombie");
        if(targets.Length <= 1){
            x++;
            waveCount.text = "Wave: " + x;
            startWave++;
            wave(startWave);
            oneTime = false;
        }
        else {
            waveCount.text = "Zombies Left: " + targets.Length;
            if(!oneTime){
                skullController.GetComponent<skullScript>().skullCount(sklScript.points + 50);
                oneTime = true;
            }
        }
    }
    
    void wave(int waveSize){
        speed++;
        for (int i = 0; i <= waveSize; i++)
        {
            GameObject Zclone = Instantiate(cloneThis, new Vector3(37.5f + i, 6.5f, 0), cloneThis.transform.rotation);
        }
    }
}
