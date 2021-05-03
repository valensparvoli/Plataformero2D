using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2D;
    public static float jumpSpeed=20;

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

        if (Input.GetKeyDown(KeyCode.Space) && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
    }

}
