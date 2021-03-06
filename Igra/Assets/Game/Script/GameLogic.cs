﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameLogic
    : MonoBehaviour
{
    public GameObject mainPanel;//panel meni koji iskoci
    public Text scoreText;//referenca na text labelu za score
    public double score = 0;//poeni
                         // Use this for initialization
    void Start()
    {
        hideMenu();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dodajScore()
    {//poziva se pri hitu na metu 
        score = score + 0.5;
    }

    public void displayMenu()
    {
        mainPanel.GetComponent<CanvasGroup>().interactable = true;
        mainPanel.GetComponent<CanvasGroup>().alpha = 1;
        scoreText.text = "Score: " + score;
        Time.timeScale = 0;
    }

    public void hideMenu()
    {
        mainPanel.GetComponent<CanvasGroup>().interactable = false;
        mainPanel.GetComponent<CanvasGroup>().alpha = 0;
        Time.timeScale = 1;
    }

    public void ponovi()
    {
        SceneManager.LoadScene("MainScena");
    }

    public void exit()
    {
        SceneManager.LoadScene("MenuScena");
    }
}
