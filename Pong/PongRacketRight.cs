using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongRacketRight : MonoBehaviour
{
    public float speed = 1f;
    public float minY;
    public float maxY;

    private void Update()
    {
        float moveY = Input.GetAxisRaw("Vertical2") * speed * Time.deltaTime;
        float newY = transform.position.y + moveY;


        if (newY > maxY)
        {
            newY = maxY;
        } 
        else if (newY < minY)
        {
            newY = minY;
        }

        transform.position = new Vector3(transform.position.x, newY, 0f);
    }
}
