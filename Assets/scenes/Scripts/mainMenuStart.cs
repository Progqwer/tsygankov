using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuStart : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject game;

    public void GameStart()
    {
        mainMenu.SetActive(false);
        game.SetActive(true);
    }   
}
