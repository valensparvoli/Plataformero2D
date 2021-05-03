using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AgarrarItems : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            PlayerController.puntaje += 1;
            Destroy(gameObject);
        }
    }

}
