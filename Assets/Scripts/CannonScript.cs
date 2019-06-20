using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CannonScript : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject cannonCamera;
    public float cannonRotationSpeed;
    public float minCorrectRot;
    public float maxCorrectRot;
    public string failScene;
    public string winScene;
    public GameObject blackoutUI;
    public float timeToPause;
    private bool locked = false;
    private bool loaded = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cannonCamera.activeInHierarchy)
        {
            cannonCamera.transform.Rotate(-Input.GetAxis("Mouse Y") * cannonRotationSpeed, 0f, 0f, Space.Self);
            cannonCamera.transform.Rotate(0f, Input.GetAxis("Mouse X") * cannonRotationSpeed, 0f, Space.World);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0) && locked)
            loaded = true;

        if (Input.GetKeyDown(KeyCode.Mouse0) && loaded)
        {
            float rot = cannonCamera.transform.eulerAngles.y;

            while (rot > 360)
                rot -= 360;
            
            while (rot < 0)
                rot += 360;
            
            StartCoroutine("EndGame", rot);
        }
    }

    private IEnumerator EndGame(float cannonPos)
    {
        blackoutUI.SetActive(true);
        yield return new WaitForSeconds(timeToPause);
        
        if (cannonPos >= minCorrectRot && cannonPos <= maxCorrectRot)
            SceneManager.LoadScene(winScene);
        else
            SceneManager.LoadScene(failScene);
    }

    public void OnMouseDown()
    {
        cannonCamera.SetActive(true);
        playerCamera.SetActive(false);
        cannonCamera.tag = "MainCamera";
        playerCamera.tag = "Untagged";
        locked = true;
    }
}
