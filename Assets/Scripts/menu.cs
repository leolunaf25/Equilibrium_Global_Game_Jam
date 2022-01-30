using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart()
    {
        SceneManager.LoadScene("Assets");
    }

    public void BotonSalir()
    {
        Application.Quit();
    }

    public void BotonInstrucciones()
    {
        SceneManager.LoadScene("instrucciones");
    }

    public void BotonCreditos()
    {
        SceneManager.LoadScene("creditos");
    }

    public void BotonMenu()
    {
        SceneManager.LoadScene("menu");
    }


}