using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManagment : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite1;
    private void OnTriggerExit2D(Collider2D collision)
    {
        Playerr.Direction = Vector3.zero;
        spriteRenderer.sprite = newSprite1;
        GetComponent<Collider2D>().isTrigger = false;
        UIManager.Current_time += 30;
        gameObject.tag = "Closed_Door";
        Playerr.Current_Level++;
    }
}
