using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
   
    public static float Current_time =0;
    float Starting_time =30;
    [SerializeField] Text Timer;


    


    void Start()
    {
        
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
