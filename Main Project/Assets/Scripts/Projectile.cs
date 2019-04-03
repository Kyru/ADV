using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0.5f;
    private Rigidbody rb;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        Debug.Log(gameObject.transform.parent);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(gameObject.transform.parent.right, ForceMode.Acceleration);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DestroyCollider")
        {
            Destroy(this.gameObject);
        }
    }
}
