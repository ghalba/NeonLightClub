using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Player.Death = true;

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Player.Death = false;
    }
}
