using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    public GameObject redObject;
    public GameObject blueObject;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(redObject.name + " : " +i++);
        Debug.Log(blueObject.name + " : " + i++);
    }
}
