using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private void Update()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, 0f);
    }

}
