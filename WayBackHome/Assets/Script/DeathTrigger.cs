﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

    //[SerializeField] private string newLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            //SceneManager.LoadScene(newLevel);
            DeadMenu.dead_state = true;

        }
    }


}
