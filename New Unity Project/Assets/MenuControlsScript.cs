using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlsScript : MonoBehaviour
{
    

    public void PlayPressed()
    {
        SceneManager.LoadScene("Test001");
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("I've closed the game!");
    }

}
