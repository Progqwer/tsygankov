using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sign_up : MonoBehaviour
{
    public GameObject SignUpWindow;
    public GameObject SignInWindow;

    public InputField loginField;

    public void Registration()
    {
        if (loginField.text == "user")
        {
            Debug.Log("Логин занят!");
            SignUpWindow.SetActive(false);
            SignInWindow.SetActive(true);
        }
    }
    public void CloseSignUp()
    {
        SignUpWindow.SetActive(false);
        SignInWindow.SetActive(true);
    }
}
