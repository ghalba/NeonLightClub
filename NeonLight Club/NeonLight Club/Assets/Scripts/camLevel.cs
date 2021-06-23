using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLevel : MonoBehaviour
{
    public Vector3[] cam_Points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cam_Points[Playerr.Current_Level];
    }
}
