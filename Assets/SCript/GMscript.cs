﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMscript : MonoBehaviour
{
    public int EnemyCount;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyCount == 0)
        {
            SceneManager.LoadScene("Success");
        }
    }
}
