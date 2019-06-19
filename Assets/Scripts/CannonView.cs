using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonView : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject cannonCamera;
    public float cannonRotationSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && cannonCamera.activeInHierarchy)
        {
            cannonCamera.SetActive(false);
            playerCamera.SetActive(true);
            playerCamera.tag = "MainCamera";
            cannonCamera.tag = "Untagged";
        }

        if (cannonCamera.activeInHierarchy)
        {
            cannonCamera.transform.Rotate(-Input.GetAxis("Mouse Y") * cannonRotationSpeed, 0f, 0f, Space.Self);
            cannonCamera.transform.Rotate(0f, Input.GetAxis("Mouse X") * cannonRotationSpeed, 0f, Space.World);
        }
    }

    public void OnMouseDown()
    {
        cannonCamera.SetActive(true);
        playerCamera.SetActive(false);
        cannonCamera.tag = "MainCamera";
        playerCamera.tag = "Untagged";
    }
}
