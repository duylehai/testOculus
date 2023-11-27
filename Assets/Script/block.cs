using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class block : MonoBehaviour
{
    public blockManagement blockManager;
    int collidedCount = 0;
    bool freezePosition = false;
    float freezedx;
    float freezedy;
    float freezedz;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!freezePosition)
        {
            updatePosition();
        }
        else
        {
            transform.position = new Vector3(freezedx, freezedy, freezedz);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        return;
        if (collision.gameObject.tag == "Ground")
            return;

        collidedCount++;
        freezePosition = true;
    }

    void OnTriggerExit(Collision collision)
    {
        return;
        if (collision.gameObject.tag == "Ground")
            return;

        collidedCount--;
        if (collidedCount == 0)
            freezePosition = false;
    }

    private Vector3 makeVec(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    void updatePosition()
    {
        freezedx = transform.position.x;
        freezedy = transform.position.y;
        freezedz = transform.position.z;
    }
}
