using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*Rigidbody _rb;

    [SerializeField] float _forwardSpeed = 2000f;
    [SerializeField] float _sideSpeed = 500f;
    private float _speed = 10.0f;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _rb.AddForce(0, 0, _forwardSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            _rb.AddForce(_sideSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            _rb.AddForce(-_sideSpeed * Time.deltaTime, 0, 0);
        }

        if (_rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    */
    [SerializeField] float _forwardSpeed = 2000f;
    float speed = 10.0f;

    Rigidbody rb;

    bool FacingRight = true;

    int directionInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, _forwardSpeed);
        rb.velocity = new Vector3(speed * directionInput, rb.velocity.y);

        if (directionInput != 0 && FacingRight)
        {
            Flip();
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    public void Move(int ImputAxis)
    {
        directionInput = ImputAxis;
    }
    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
