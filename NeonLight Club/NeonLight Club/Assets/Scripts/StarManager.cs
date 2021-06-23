using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    public GameObject ef;
    public SpriteRenderer spriteRenderer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Playerr.Stars_Collected++;
        spriteRenderer.sprite = null;
        Instantiate(ef, transform);
        Destroy(gameObject, 0.3f);
        

    }
}
