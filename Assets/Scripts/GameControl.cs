﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Attach to GameController

public class GameControl : MonoBehaviour {

    public static GameControl instance;

    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -3f;
    public Text scoreText;

    private int score = 0;

	// Use this for initialization
    void Awake ()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update ()
    {
        if(gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void BirdScored()
    {
        if(gameOver)
        {
            return;
        }

        score++;
        scoreText.text = "Score : " + score.ToString();


    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

}
