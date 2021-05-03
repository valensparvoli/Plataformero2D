using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;
    Vector2 player;
    Rigidbody2D rb2D;

    void Start()
    {
        GetComponent<Transform>();
        rb2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        float hMovement = Input.GetAxis("Horizontal")*Time.deltaTime*speed;

        transform.Translate(hMovement, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
    }

}
