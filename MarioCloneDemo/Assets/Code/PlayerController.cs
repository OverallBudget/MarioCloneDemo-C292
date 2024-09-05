using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float runSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private Vector2 direction;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(moveInput * Vector2.right * runSpeed * Time.deltaTime);
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && rb2d.velocity.y == 0)
        {
            rb2d.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }
}
