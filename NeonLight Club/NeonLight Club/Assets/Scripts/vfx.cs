using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vfx : MonoBehaviour
{
    public Vector3 theScale;
    public float animSpeed =1f;
    // Start is called before the first frame update
    void Start()
    {
        theScale.x=0f;
        theScale.y=0.01f;
        theScale.z=0f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, theScale, Time.deltaTime * animSpeed);
    }
    public void onMove()
    {
         theScale.x = 0.01f;
    }
    public void onStop()
    {
         theScale.x = 0f;
    }
}
