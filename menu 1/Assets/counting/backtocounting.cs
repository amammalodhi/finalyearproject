using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtocounting : MonoBehaviour {

    public void backcounting()
    {
        SceneManager.LoadScene("counting", LoadSceneMode.Single);
    }
}
