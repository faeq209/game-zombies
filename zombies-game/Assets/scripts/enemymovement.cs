using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemymovement : MonoBehaviour
{
    // Start is called before the first frame update
    public AIPath aipath;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aipath.maxSpeed = Random.Range(3, 10);
        if (aipath.desiredVelocity.x >= 0.001f)// || aipath.desiredVelocity.y >= 0.001f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        else if (aipath.desiredVelocity.x <= 0.001f)//|| aipath.desiredVelocity.y <= 0.001f)
        {

            transform.localScale = new Vector3(-1f, 1f, 1f);

        }
    }
}
