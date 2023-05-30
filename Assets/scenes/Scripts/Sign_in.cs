using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign_in : MonoBehaviour
{
    public GameObject SignInWindow;
    public GameObject mainWindow;
    public GameObject signUpWindow;

    public InputField login;
    public InputField password;

    public void AuthProcess()
    {
        if (login.text == "user")
        {
            if(password.text == "12345")
            {
                SignInWindow.SetActive(false);
                mainWindow.SetActive(true);
            }
            else
            {
                Debug.Log("Неверный пароль");
            }
        }
        else
        {
            Debug.Log("Неверный логин");
        }
    }

    public void OpenSingUp()
    {
        SignInWindow.SetActive (false);
        signUpWindow.SetActive(true);
        
    }
}
