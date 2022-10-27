using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skullScript : MonoBehaviour
{
    
    public Text skullText;
    public int points;
    public void skullCount(int skulls){
        this.points = skulls;
        skullText.text = "Skulls:" + points;
    }
}
