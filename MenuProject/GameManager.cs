﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
       
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
