﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingLvlScripot : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
