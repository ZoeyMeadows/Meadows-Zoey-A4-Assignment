using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fly_Control : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f; //setup momentum
    [SerializeField] private float rotationSpeed = 10f; //setup rotation
    private Rigidbody2D rb;
    private void Start()//append rigidbody
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) //move when clicked, moving by velocity
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.gameOver();
    }
}
