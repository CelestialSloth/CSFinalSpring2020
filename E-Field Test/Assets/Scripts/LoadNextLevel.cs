using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public void loadNextLevel()
    {
        //if(notLastLevel)
        //load next index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
