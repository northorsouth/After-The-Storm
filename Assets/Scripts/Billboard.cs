using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform player = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Transform t = player;

        if (t == null)
            t = Camera.main.transform;
        
        Vector3 rot = transform.localEulerAngles;

        rot.y = t.eulerAngles.y;
        
        transform.localEulerAngles = rot;
    }
}
