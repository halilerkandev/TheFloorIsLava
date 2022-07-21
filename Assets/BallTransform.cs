using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 maxScaleVal = new Vector3(5, 5, 5);

        if(transform.localScale.x <= maxScaleVal.x && transform.localScale.y <= maxScaleVal.y && transform.localScale.z <= maxScaleVal.z )
        {
            transform.localScale += (scaleChange * Time.deltaTime);

        }
        
    }
}
