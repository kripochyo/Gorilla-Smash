﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene1 : MonoBehaviour
{
    public  void ButtonPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonBack()
    {
        SceneManager.LoadScene(0);
    }
}
