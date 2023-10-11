using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 movment;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveplayer();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movment = context.ReadValue<Vector2>();
    }

    public void moveplayer()
    {
        Vector3 move = new Vector3(movment.x, 0f, movment.y);
        if (move.magnitude > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(move), 0.15f);
        }
        rb.velocity = move * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "speedcube")
        {
            speed = speed + 20;
        }
    }
}
