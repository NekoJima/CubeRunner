
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward;
    public float sideforward;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()

    {
        rb.AddForce(0, 0, forward * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sideforward * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))

        {
            rb.AddForce(-sideforward * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y <-1f)
        {
            FindObjectOfType<GameManagement>().GameOver();
        }
    }
}

    

