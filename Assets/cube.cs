using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotateZ(10);
        }
    }

    public void rotateZ(int angle)
    {
        Transform cubeTransform = this.GetComponent<Transform>();
        cubeTransform.Rotate(new Vector3 (0, 0, angle));
    }
}
