using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject _registerLoginscreen;
    public GameObject _loginscreen;

    public void RegisterLogin()
    {
        _registerLoginscreen.gameObject.SetActive(true);
        _loginscreen.gameObject.SetActive(false);
    }

    public void closebutton()
    {
        _registerLoginscreen.gameObject.SetActive(false);
        _loginscreen.gameObject.SetActive(true);
    }
}
