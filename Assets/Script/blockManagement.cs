using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockManagement : MonoBehaviour
{
    private block[] blocklist;

    public block[] getBlocksInstance()
    {
        return blocklist;
    }

    // Start is called before the first frame update
    void Start()
    {
        blocklist = (block[]) FindObjectsOfType(typeof(block));
        //print("sized: "  + blocklist.ToArray().Length.ToString());
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
