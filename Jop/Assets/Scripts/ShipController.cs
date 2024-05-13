using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    float verticalSpeed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        float horizontalSpeed = Input.GetAxis("Horizontal");
        verticalSpeed = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = offSet(speed);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

        if (transform.rotation.y < 45 && transform.rotation.y > -45)
        {
            transform.Rotate(0, horizontalSpeed * rotationSpeed * Time.deltaTime, 0);
        }        
    }

    private Vector3 offSet(float _speed)
    {
        Vector3 dir = transform.forward;
        Vector3 direction = dir + new Vector3(0, 0, _speed * Time.deltaTime);
        return direction;
    }
}
