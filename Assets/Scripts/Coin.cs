using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int score; // En static modifierare gör ...

    public int amount = 1;

    private float spinSpeed = 180;

    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0); // Roterar coin spriten varje frame
    }

    // 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Coin.score += amount; // Lägger till amount på score 
            Destroy(gameObject); // Förstör coin spriten
        }
    }
}
