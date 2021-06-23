using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        Destroy(gameObject,1.2f);
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Playerr.Death = true;
            Debug.Log(col.gameObject.name + "killed");
            
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
