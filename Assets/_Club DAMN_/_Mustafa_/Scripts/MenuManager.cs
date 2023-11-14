using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Exit()
    {
        EditorApplication.isPlaying = false;
        // Application.Quit();
    }



    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}
