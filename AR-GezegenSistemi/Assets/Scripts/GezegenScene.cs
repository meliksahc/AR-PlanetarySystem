using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GezegenScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void GunesSahnesine()
    {
        SceneManager.LoadScene("gunes");
    }
    public void dunyaSahnesine()
    {
        SceneManager.LoadScene("dunya");
    }
    public void merkurSahnesine()
    {
        SceneManager.LoadScene("merkur");
    }
    public void marsSahnesine()
    {
        SceneManager.LoadScene("mars");
    }
    public void jupiterSahnesine()
    {
        SceneManager.LoadScene("jupiter");
    }
    public void saturnSahnesine()
    {
        SceneManager.LoadScene("satürn");
    }
    public void neptunSahnesine()
    {
        SceneManager.LoadScene("neptun");
    }
    public void uranüsSahnesine()
    {
        SceneManager.LoadScene("uranüs");
    }
    public void venusSahnesine()
    {
        SceneManager.LoadScene("venus");
    }
    public void GalaksiSahnesine()
    {
        SceneManager.LoadScene("GalaksiSistemimiz");
    }
    public void MenuSahnesine()
    {
        SceneManager.LoadScene("Menu");
    }

}
