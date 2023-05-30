using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject buildWindow;

    public void OpenBuildWindow()
    {
        buildWindow.SetActive(true);
    }

    public void UseRoad()
    {
        
    }
    public void UseDirt()
    {

    }

    public void CloseBuildWindow()
    {
        buildWindow.SetActive(false);
    }
}
