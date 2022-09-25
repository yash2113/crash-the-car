using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thanksforplaying : MonoBehaviour
{
    // Start is called before the first frame update
    public void returnToMainMenu()
    {
        SceneManager.LoadScene("main");
    }
    public void returnToStart()
    {
        SceneManager.LoadScene("start");
    }
}
