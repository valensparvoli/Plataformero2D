using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemScript : MonoBehaviour
{
    public GameObject win;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            PlayerController.jumpSpeed = 20;
            Destroy(gameObject);
            win.SetActive(true);
        }
    }
}
