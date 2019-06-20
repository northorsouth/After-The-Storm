using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[RequireComponent(typeof(RigidbodyFirstPersonController))]
public class ToggleFrozen : MonoBehaviour
{
    private RigidbodyFirstPersonController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Freeze()
    {
        controller.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void UnFreeze()
    {
        controller.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
