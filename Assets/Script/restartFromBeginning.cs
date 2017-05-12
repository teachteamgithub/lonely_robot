﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartFromBeginning : MonoBehaviour {
    public Transform Player;


    void Awake()
    {
     // Player.position = new Vector3(-698, -49, 0);
	  Player.position = new Vector3(191, 45, 0);

        Player.eulerAngles = new Vector3(0, PlayerPrefs.GetFloat("Cam_y"), 0);


    }

    public void restartGameFromBeginning()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
