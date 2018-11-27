using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;

    private Rigidbody2D rbody;

    void Start()
    {
        //hämtar en Rigidbody till enemy
        rbody = GetComponent<Rigidbody2D>();
    }


    //funktionen kallar varje fast framerate-ram. användas istället för Update när det handlar om Rigidbody
    private void FixedUpdate()
    {
        //kollar om boolen left är true
        if (left == true)
        {
            //sätter hastigheten på enemy till vänster
            //(Vector2) betyder att man konverterar från Vector3
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        //om boolen left är false så gör den detta
        else
        {
            //sätter hastigheten på enemy till höger
            //(Vector2) betyder att man konverterar från Vector3
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kollar om det händer en kollision med en tag som heter "InvisibleWall"
        if (collision.tag == "InvisibleWall")
        {
            //om enemy går in i InvisibleWall så ändrar den riktning
            left = !left;
        }
    }
}
