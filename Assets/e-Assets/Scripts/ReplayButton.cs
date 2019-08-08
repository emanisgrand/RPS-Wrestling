﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour {
    private string levelToLoad = "gameplay-Staging";

    public void Proceed() {
        SceneManager.LoadScene(levelToLoad);
    }
}
