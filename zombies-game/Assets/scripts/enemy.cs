using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemyRotation : MonoBehaviour
{
    // Start is called before the first frame update

    public AIPath aipath;
    
    private void Start()
    {
       // aipath.velocity = Random.Range(3, 100);
    }
    // Update is called once per frame
    void Update()
    {
        if(aipath.desiredVelocity.x>=0.001f)// || aipath.desiredVelocity.y >= 0.001f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);

        } else if (aipath.desiredVelocity.x <= 0.001f )//|| aipath.desiredVelocity.y <= 0.001f)
        {

            transform.localScale = new Vector3(-1f, 1f, 1f);

        }
    }
}
