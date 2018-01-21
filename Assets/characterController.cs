using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {
    public float speed;
    CharacterController controller;
    public Rigidbody rb;
    public float thrust = 4f;

    public GameObject sphere;
    // Use this for initialization
    void Start () {
        speed = 2.0f;
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update() {
        //WASD controls
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        
        //jumping
        if (Input.GetKey(KeyCode.Space) )
        {
            rb.AddForce(transform.up * thrust, ForceMode.Impulse);
        }
        

        


        // walk speed multiplier
        if (Input.GetKey(KeyCode.LeftShift))
        {
            while(speed <= 4.0f)
            speed += 0.005f;
    }
        else
        speed = 2.0f;
    }
}
