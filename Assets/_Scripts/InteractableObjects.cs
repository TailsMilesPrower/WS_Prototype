using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjects : MonoBehaviour
{
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnMouseDown()
    {
        rb.useGravity = true;

        Vector3 forwardForce = transform.position * 2f;
        rb.AddForce (forwardForce, ForceMode.Impulse);
    }
}
