using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isGrounded;

    // 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true; // Ger boolen ett true värde när groundChecker collidern nuddar ground
    }


    // 
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false; // Ger boolen ett false värde när groundChecker collidern inte nuddar  ground
    }
}
