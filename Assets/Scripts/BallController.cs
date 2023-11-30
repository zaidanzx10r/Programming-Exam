using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;

    [Header("Camera")]
    [SerializeField] private Transform followTarget;

    private Rigidbody rb;

    private bool isGrounded;
    private Vector3 _moveDirection;

    void Start()
    {
        InputManager.Init(this);
        InputManager.Game();

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += transform.rotation * (speed * Time.deltaTime * _moveDirection);
        checkGrounded();

        if (Input.GetKey(KeyCode.Mouse0))
        {
            rb.AddForce(speed * transform.forward);
        }
    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        _moveDirection = newDirection;
        
    }

    private void checkGrounded()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y);
        Debug.DrawRay(transform.position, Vector3.down * GetComponent<Collider>().bounds.size.y, Color.green, 0, false);
    }

}
