using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2 : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, time);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
         if (col.gameObject.name == "Player")
        {
            Playerr.Death = true;
            Debug.Log(col.gameObject.name+  "killed");
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Playerr.Death = false;
            Debug.Log(col.gameObject.name + "killed");
        }
    }
}
