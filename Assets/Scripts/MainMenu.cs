using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button creditButton;
    public Button exitButton;

     private void Start()
     {
        playButton.onClick.AddListener(PlayGame);
        creditButton.onClick.AddListener(CreditButton);
        exitButton.onClick.AddListener(ExitGame);
        
     }

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void CreditButton()
    {
        SceneManager.LoadScene("CreditMenu");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
