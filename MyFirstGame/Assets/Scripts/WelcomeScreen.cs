﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class WelcomeScreen : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
