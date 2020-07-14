﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public string mainMenu = "mainMenu";
    public SceneFader sceneFader;

    public void TryAgain()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }


    public void Menu()
    {
        sceneFader.FadeTo(mainMenu);
    }
}