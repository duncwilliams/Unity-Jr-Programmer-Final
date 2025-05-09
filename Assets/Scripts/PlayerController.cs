using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        HorizontalMovement();
    }

    private void HorizontalMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 horizontalMovement = horizontalInput * transform.right * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + horizontalMovement);
    }
}
