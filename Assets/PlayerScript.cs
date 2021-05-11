using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(Input.GetKey("g"))
        {
            rb.AddForce(0, 6000 * Time.deltaTime, 0);
        }

    }
}
