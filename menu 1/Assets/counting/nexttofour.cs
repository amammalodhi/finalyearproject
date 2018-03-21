using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nexttofour : MonoBehaviour {

    public void nextfour()
    {
        SceneManager.LoadScene("four", LoadSceneMode.Single);
    }
}

