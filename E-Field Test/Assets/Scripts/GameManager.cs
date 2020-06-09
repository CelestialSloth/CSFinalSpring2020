using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;

    //I think this is scene-specific
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);

        //load end of level scene. (Congratulations + nextLevel button) Provide it with the current level number
        
    }

   
}
