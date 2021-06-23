using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiMangerHard : MonoBehaviour
{

    public static float Current_time = 0;
    float Starting_time;
    [SerializeField] Text Timer;





    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "levels 1")
        {
            Starting_time = 20f;
        }
        if (scene.name == "levels")
        {
            Starting_time = 30f;
        }
        Current_time = Starting_time;
    }


    void Update()
    {
        Current_time -= 1 * Time.deltaTime;
        Timer.text = Current_time.ToString("0");
        if (Current_time <= 0)
        {
            Current_time = 0;
            SceneManager.LoadScene("lose");
        }



    }

}