using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinPartida : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene("PillaPillaGame");
    }
}
