using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float pipeSpeed = 2.0f;
    public float despawnX = -10.0f;

    void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);

        if (transform.position.x < despawnX)
        {
            Destroy(gameObject);
        }
    }
}
