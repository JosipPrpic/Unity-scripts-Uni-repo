using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    public float speed = 1f;
    Vector3 velocity;

    public bool right;
    public bool left;
    public bool up;
    public bool down;

    private void Update()
    {
        UpdateVelocity();
        transform.position += velocity * Time.deltaTime;
    }

    void UpdateVelocity()
    {
        if(right && up)
        {
            velocity = new Vector3(1f, 1f, 0) * speed;
        } 
        else if (right && down)
        {
            velocity = new Vector3(1f, -1f, 0) * speed;
        }
        else if (left && up)
        {
            velocity = new Vector3(-1f, 1f, 0) * speed;
        }
        else if (left && down)
        {
            velocity = new Vector3(-1f, -1f, 0) * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string side = collision.transform.name;

        if(side == "Top" && up)
        {
            up = false;
            down = true;
        }
        if (side == "Bottom" && down)
        {
            up = true;
            down = false;
        }
        if (side == "Right" && right)
        {
            right = false;
            left = true;
        }
        if (side == "Left" && left)
        {
            right = true;
            left = false;
        }
    }
}
