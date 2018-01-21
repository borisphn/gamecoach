using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject sphere;

    Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = sphere.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        float desiredAngle = sphere.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = sphere.transform.position - (rotation * offset);
        transform.LookAt(sphere.transform);
    }
}