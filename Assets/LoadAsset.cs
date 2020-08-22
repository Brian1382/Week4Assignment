using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAsset : MonoBehaviour
{
    public GameObject redObject;
    [SerializeField]
    private GameObject blueObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(blueObject, new Vector3(2, 0, 0), Quaternion.identity);
            Instantiate(redObject, new Vector3(-2, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
