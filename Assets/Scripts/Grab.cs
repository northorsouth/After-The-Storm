﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    private Transform originalParent;
    private Rigidbody rb = null;
    private bool grabbed = false;
    
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
        if (!grabbed)
        {
            transform.parent = Camera.main.transform;

            transform.rotation = transform.parent.rotation;

            if (rb)
                rb.isKinematic = true;
            
            grabbed = true;
        }
        
        else
        {
            transform.parent = originalParent;
            if (rb)
                rb.isKinematic = false;
            
            grabbed = false;
        }
    }
}
