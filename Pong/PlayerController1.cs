using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    // Brzina pomaka
    public float speed = 10;

    void FixedUpdate()
    {
        // Dohvat pomaka po vertikalnoj osi
        float vertical = Input.GetAxis("Vertical 2");

        //Pomicanje objekta
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertical) * speed;
    }
}
