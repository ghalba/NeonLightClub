using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bang : MonoBehaviour
{
    public GameObject laserShotprefab;
    float myTimer = 0f;
    public float shootRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myTimer += Time.deltaTime;
        if(myTimer> shootRate )
        {
            Instantiate(laserShotprefab, transform);
            myTimer = 0f;

        }
        
    }
}
