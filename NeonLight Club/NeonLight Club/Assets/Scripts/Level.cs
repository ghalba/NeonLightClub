using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public int Stars_Required;
    public Collider2D Exit_Door;
    public void Start()
    {
     
    }
    public void Update()
    {
        PassLevel();

    }

    public void PassLevel()
    {
        if(Playerr.Stars_Collected == Stars_Required)
        {
            Exit_Door.isTrigger = true;
            Exit_Door.tag = "Opened_Door";
            spriteRenderer.sprite = newSprite;

        }
    }
    
}
