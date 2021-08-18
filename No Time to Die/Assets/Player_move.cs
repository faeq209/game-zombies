using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public Transform traansform;
    public float movespeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 temp;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

        if (movement.x == 0 && movement.y == 0)
        {
            temp = transform.localScale;
            temp.x = 3;
            temp.y = 3;
            transform.localScale = temp;
        }
        else
        {
            temp = transform.localScale;
            temp.x = 5;
            temp.y = 5;
            transform.localScale = temp;

        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
