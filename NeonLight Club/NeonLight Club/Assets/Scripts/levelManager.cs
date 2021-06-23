using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelManager : MonoBehaviour
{
    public Vector3[] Spawn_Points;
    public GameObject Player_Tobe_Changed;
    public void Update()
    {
        if (Playerr.Death)
        {
            Player_Tobe_Changed.transform.position = Spawn_Points[Playerr.Current_Level];
            

        }
        if (Playerr.Stars_Collected == 60)
        {
            SceneManager.LoadScene("Win");
        }
    }

}