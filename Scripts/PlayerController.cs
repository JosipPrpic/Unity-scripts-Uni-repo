using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Brzina pomaka
    public float speed = 30;
    void FixedUpdate()
    {
        // Dohvat pomaka po vertikalnoj osi
        float vertical = Input.GetAxis("Vertical");
        // Pomicanje objekta
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,vertical) * speed;

        //w s kontroler
        float vertical2 = Input.GetAxis("Vertical 2");
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, vertical2) * speed;
    }
}
