using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 hori_velocity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hori_velocity.x *= (float)0.0;
        
        if (Input.GetKeyDown(KeyCode.Space) && rb.linearVelocity.y <= 0)
        {
            rb.AddForce(Vector2.up * 200);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (hori_velocity.x > 0)
            {
                hori_velocity.x = -hori_velocity.x;
            }
            hori_velocity += Vector2.left * 100;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (hori_velocity.x < 0)
            {
                hori_velocity.x = -hori_velocity.x;
            }
            hori_velocity += Vector2.right * 100;
        }
        
        rb.AddForce(hori_velocity);
    }
}
