using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform ObjToFollow;
    Vector3 distance;
    public float smoothvalue = 1f;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - ObjToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destiny = ObjToFollow.position + distance;
        transform.position = Vector3.Lerp(transform.position, destiny, Time.deltaTime * smoothvalue);
    }
}
