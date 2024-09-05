using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformMove : MonoBehaviour
{

    [SerializeField] private bool canMove;
    [SerializeField] private bool canRotate;
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float offset = 5;
    [SerializeField] private float rotateSpeed = 5;

    private Vector2 startPosition;
    private bool isMovingRight = true;

    private void Awake() // awake creates before start
    {
        startPosition = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoopPlatform();
    }

    private void LoopPlatform()
    {
        if (canMove)
        {
            MovePlatform();
        }
        if (canRotate)
        {
            RotatePlatform();
        }
    }
   
    private void RotatePlatform()
    {
        //transform.Rotate(Vector2.right * rotateSpeed * Time.deltaTime); // doing this rotates z axis lmao
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
    private void MovePlatform()
    {
        if (transform.position.x > startPosition.x + offset)
        {
            isMovingRight = false;
        }
        if (transform.position.x < startPosition.x - offset)
        {
            isMovingRight = true;
        }
        if (isMovingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
}
