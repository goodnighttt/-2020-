using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeMeasure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var size = transform.GetComponent<Renderer>().bounds.size;
        Debug.Log("x: " + size.x + ",y: " + size.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
