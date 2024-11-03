using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAgent : MonoBehaviour
{
    public float jumpVelocity = 5f; 
    private Rigidbody2D rb;
    public float rotation = 2f;

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
        UpdateRotation();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pipe"))
        {
            Debug.Log("COLLIDED WITH PIPE D:"); //ändra det här att restarta å börja ny episod när vi fixar agenten sen
        }
    }

    void UpdateRotation()
    {
        float fallSpeed = rb.velocity.y;
        float rotationAngle = Mathf.Clamp(fallSpeed * rotation, -90f, 45f); 
        transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
    }
}
