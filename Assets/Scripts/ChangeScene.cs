using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour //class decalartion 
{  //openeing braces for class
    
    //creating various functions for shifting from once scene to another from main menu using various buttons
    
    public void Scan() 
    {
        SceneManager.LoadScene("Smartphones");
    }

    public void Welcome() 
    {
        SceneManager.LoadScene("Welcome");
    }

    public void quit() //to quit the application
    {
        Application.Quit();
        Debug.Log("Exit Button Pressed");
    }
} //closing braces for class
