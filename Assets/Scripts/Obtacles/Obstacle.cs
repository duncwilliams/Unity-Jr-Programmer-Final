using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // ENCAPSULATION
    protected float speed { private get; set; }
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
        
    }

    public virtual void Flow() 
    {
        rb.AddForce(flowDirection * speed * Time.deltaTime);
    }
}
