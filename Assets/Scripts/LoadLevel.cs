using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int minimumScoreNeeded = 0;
    public string sceneToLoad = "SampleScene"; // Gör "SampleScene" till standardvärdet på vilken scen som ska laddas

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kollar om det händer en kollison med taggen "Player", 
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            Coin.score = 0; // Gör så att när scenen laddas om så börjar score på 0
            SceneManager.LoadScene(sceneToLoad); // Laddar in standard scenen som nu är "SampleScene"
        }
    }
}
