using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform player = null;
    
    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
            player = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Vector3 rot = transform.localEulerAngles;

        rot.y = player.transform.eulerAngles.y;
        
        transform.localEulerAngles = rot;
    }
}
