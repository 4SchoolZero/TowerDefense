using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameOverScript : MonoBehaviour
{
     void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Zombie")
        {
            SceneManager.LoadScene (sceneName:"gameOver");
        }
    }
}
