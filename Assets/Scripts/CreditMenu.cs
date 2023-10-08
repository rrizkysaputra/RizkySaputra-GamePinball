using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditMenu : MonoBehaviour
{
    public Button backMenu;

    private void Start()
    {
       backMenu.onClick.AddListener(MainMenu);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
