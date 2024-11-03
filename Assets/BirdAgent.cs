using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAgent : MonoBehaviour
{
    public float jumpVelocity = 5f; 
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
        }
    }
}
