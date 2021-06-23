using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager2 : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite1;
    float y;
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "levels 1")
        {
            y= 15f;
        }
        if (scene.name == "levels")
        {
            y= 20f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        Playerr.Direction = Vector3.zero;
        spriteRenderer.sprite = newSprite1;
        GetComponent<Collider2D>().isTrigger = false;
        UiMangerHard.Current_time += y;
        gameObject.tag = "Closed_Door";
        Playerr.Current_Level++;
    }
}
