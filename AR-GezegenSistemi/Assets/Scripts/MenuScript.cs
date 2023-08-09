using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void GalaksiSahnesine()
    {
        SceneManager.LoadScene("GalaksiSistemimiz");
    }

    // Update is called once per frame
    public void uygulamakapat()
    {
        Application.Quit();
    }
}
