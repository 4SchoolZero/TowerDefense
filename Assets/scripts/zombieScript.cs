using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class zombieScript : MonoBehaviour
{
    public Transform[] targets;
    public waveScript wScript;
    private Animator anim;
    private int x = 0;
    // Update is called once per frame
    void Update()
    {
        walkTo();
    }
  
    void walkTo(){
        for (int i = 0; i <= targets.Length; i++)
        {
            var step =  wScript.speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targets[x].position, step);
            if (Vector3.Distance(transform.position, targets[x].position) < 0.5f)
            {
                x++;
                SceneManager.LoadScene (sceneName:"gameOver");
            }
            if(x >= targets.Length) x = 0;
        }
    }
}
