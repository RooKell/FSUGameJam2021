using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TitleScreen : MonoBehaviour
{

    //This method gets called when clicking on the PlayButton on the Main Menu.
    //Load the GameScene. 
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    //This method gets called when clicking on the QuitButton on the Main Menu.
    //Call the Application.Quit() method to quit the game.
    public void QuitGame()
    {
        Application.Quit();
    }
}
