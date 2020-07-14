using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver;

    public GameObject gameObjectUI;

    public GameObject CompleteLevelUI;

    private void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
            return;

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        isGameOver = true;
        gameObjectUI.SetActive(true);
    }

    public void WinLevel()
    {
        isGameOver = true;
        CompleteLevelUI.SetActive(true);
    }
}
