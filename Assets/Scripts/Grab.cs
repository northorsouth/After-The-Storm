using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    private Transform originalParent;
    private Rigidbody rb = null;
    
    // Start is called before the first frame update
    void Start()
    {
        originalParent = transform.parent;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        transform.parent = Camera.main.transform;

        if (rb)
            rb.isKinematic = true;
    }

    void OnMouseUp()
    {
        transform.parent = originalParent;
        if (rb)
            rb.isKinematic = false;
    }
}
