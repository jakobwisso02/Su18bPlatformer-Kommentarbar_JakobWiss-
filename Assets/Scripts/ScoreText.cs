﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

    // Use this for initialization
    void Start()
    {
        //hämtar textmesh komponent
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //visar score på hud:en,  lägger till score när man collidar med ett coin, (Coin.score) länkar till coinscriptet
        text.text = string.Format("Score: {0:0000}", Coin.score);
    }
}