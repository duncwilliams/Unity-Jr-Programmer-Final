using UnityEngine;

public class Obstacle : MonoBehaviour
{
    protected float speed = 1000f;
    protected float pointValue;
    protected Rigidbody rb;

    private Vector3 flowDirection = Vector3.back;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Flow();
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        // point adding logic goes here
    }

    public virtual void Flow() 
    {
        rb.AddForce(flowDirection * speed * Time.deltaTime);
    }
}
