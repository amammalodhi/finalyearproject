using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nexttothree : MonoBehaviour
{

    public void nextthree()
    {
        SceneManager.LoadScene("three", LoadSceneMode.Single);
    }
}

