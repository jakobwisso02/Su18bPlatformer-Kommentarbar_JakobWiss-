﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int score; //

    public int amount = 1;

    private float spinSpeed = 180;

    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0); //roterar coin spriten
    }

    //
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Coin.score += amount; //lägger till amount på score 
            Destroy(gameObject); //förstör coin sprite
        }
    }
}