using UnityEngine;

// INHERITANCE
public class Bad : Obstacle
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        pointValue = -5f;
        speed = 250f;
    }

    // POLYMORPHISM
    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // TODO: play death effect at other.position
            base.OnTriggerEnter(other);
            Destroy(other);
        }
        else if (other.CompareTag("Backstop"))
        {
            Destroy(gameObject);
        }
    }
}
