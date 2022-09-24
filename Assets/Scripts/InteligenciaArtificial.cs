using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteligenciaArtificial : MonoBehaviour
{
    public float speed=3;

    public GameObject ball;

    private Vector2 ballpos;
   
    void Update()
    {
        Move();
    }

    void Move()
    {
        ballpos = ball.transform.position;

        if(transform.position.y > ballpos.y)
        {
            transform.position += new Vector3(0, -speed*Time.deltaTime);
        }
        if(transform.position.y < ballpos.y)
        {
            transform.position += new Vector3(0, speed*Time.deltaTime);
        }
    }
}
