using System;
using UnityEngine;

public class Movement : MonoBehaviour

{
    [Header("Config Movement")]
    [SerializeField] private KeyCode MoveUp = KeyCode.W;
    [SerializeField] private KeyCode MoveDown = KeyCode.S;

    [Header("Config Speed")]
    public float moveSpeed = 1500f;

    private Rigidbody2D rb;
    private Vector2 moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float Xdirection = 0f;
        float Ydirection = 0f;

        if (Input.GetKey(MoveUp))
        {
            Ydirection = 1f;
        }

        if (Input.GetKey(MoveDown))
        {
            Ydirection = -1f;
        }

        moveDirection = new Vector2(Xdirection, Ydirection).normalized;
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * (moveSpeed * Time.deltaTime), ForceMode2D.Force);
    }
}
