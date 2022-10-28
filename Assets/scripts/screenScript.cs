using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class screenScript : MonoBehaviour
{
    public void controller(string scene = ""){
        SceneManager.LoadScene (sceneName:scene);
        if(scene == "exit"){
            Application.Quit();
        }
    }
}
