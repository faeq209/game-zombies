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

    public GameObject losingtext;
    public GameObject enemyprefab;
    public float spawnRate;
    float nextspawn;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("enemy")) {

            this.gameObject.SetActive(false);
            losingtext.SetActive(true);
        }
    }
    void Start()
    {
        losingtext.SetActive(false);
        currenthealth = maxhealth;
        h.setmaxhealth(maxhealth);
    }

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
        if (Time.time>nextspawn)
        {
            nextspawn = Time.time + spawnRate;
            Instantiate(enemyprefab);


        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
    void takedamage(float damage)
    {
        currenthealth -= damage* Time.fixedDeltaTime;
        if (currenthealth == 0) { losingtext.SetActive(true); }
        h.sethealth(currenthealth);
    }
}
