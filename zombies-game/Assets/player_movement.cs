using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public healthbar h;
    public float maxhealth = 100;
    public float currenthealth;
    public Transform traansform;
    public float movespeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 temp;
    void Start()
    {
        currenthealth = maxhealth;
        h.setmaxhealth(maxhealth);
    }
    // Update is called once per frame
    void Update()
    {//if (Input.GetKeyDown(KeyCode.Space)) takedamage(20);
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
            
           takedamage(1);
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
    void takedamage(float damage)
    {
        currenthealth -= damage* Time.fixedDeltaTime;
        h.sethealth(currenthealth);
    }
}
