using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float maxSpeed = 6.0f;
    public float moveDirection;
    public bool facingRight = true;
    private new Rigidbody rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector2 (moveDirection * maxSpeed, rigidbody.linearVelocity.y);

        if (moveDirection > 0.0f && !facingRight)
        {
            flip();
        }
        else if (moveDirection < 0.0f && facingRight)
        {
            flip();
        }

    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up,180.0f, Space.World);
    }
}
