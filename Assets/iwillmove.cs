using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iwillmove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime*200);
            transform.Rotate(Vector3.right * Time.deltaTime*200);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-1*Vector3.forward * Time.deltaTime*200);
            transform.Rotate(-1*Vector3.right * Time.deltaTime*200);
        }
    }
}
