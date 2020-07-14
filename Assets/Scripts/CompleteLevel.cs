using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public SceneFader sceneFader;

    public string menuSceneName = "mainMenu";

    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }

    public void Continue()
    {
        if (levelToUnlock > PlayerPrefs.GetInt("levelReached", 1))
        {
            Debug.Log("LEVEL WON");
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
            sceneFader.FadeTo(nextLevel);
        }
        else
        {
            sceneFader.FadeTo(menuSceneName);
            PlayerPrefs.SetInt("levelReached", 1);
        }
    }
}
