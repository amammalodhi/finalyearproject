using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nexttofive : MonoBehaviour {


    public void nextfive()
    {
        SceneManager.LoadScene("five", LoadSceneMode.Single);
    }
}
