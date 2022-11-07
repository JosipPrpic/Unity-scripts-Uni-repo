using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Web;
using System.Linq;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float MoveValue;

    

    private void Update()
    {
        Jump();
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontal, 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        gameObject.GetComponent<Animator>().SetFloat("MoveValue", Math.Abs(horizontal));

    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
        
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }
}