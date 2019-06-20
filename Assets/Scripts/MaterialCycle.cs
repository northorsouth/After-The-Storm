using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCycle : MonoBehaviour
{
    public Material[] frames;
    public float speed;
    private int currentFrame = 0;

    private MeshRenderer rendy;
    
    // Start is called before the first frame update
    void Start()
    {
        rendy = GetComponent<MeshRenderer>();
        StartCoroutine("Cycle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Cycle()
    {
        Debug.Log("Frame");
        
        rendy.material = frames[currentFrame];

        currentFrame++;
        if (currentFrame >= frames.Length)
            currentFrame = 0;
        
        yield return new WaitForSeconds(speed);

        StartCoroutine("Cycle");
    }
}
