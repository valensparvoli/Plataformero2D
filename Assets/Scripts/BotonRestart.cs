using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonRestart : MonoBehaviour
{


    public void Restart()
    {
        SceneManager.LoadScene("PrimerNivel");
        PlayerController.puntaje = 0;
    }
}
