using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazerRotating : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.name == "Player")
                Playerr.Death = true;
        }
        void OnTriggerExit2D(Collider2D col)
        {
            if (col.gameObject.name == "Player")
                Playerr.Death = false;
        }
    }
