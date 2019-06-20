using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour
{
    public string BoozeTag;
    public CannonScript cannon;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag.Equals(BoozeTag))
        {
            Destroy(c.gameObject);
            cannon.LightFuse();
            GetComponent<Collider>().enabled = false;
        }
    }
}
