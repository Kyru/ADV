using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private float speed = 50f;
    public Texture texture;

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);

        //GetComponent<Renderer>().material.mainTexture = texture;

    }
}
