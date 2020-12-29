using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void CampainPressed()
    {
        SceneManager.LoadScene("World");
    }

    public void ExitPressed()
    { 
        Application.Quit();
     
    }
}
