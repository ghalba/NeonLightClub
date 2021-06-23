using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class smothCamera : MonoBehaviour
{

    public Vector3 nextPosition; //or public Vector3 nextPosition; if in C#
    float moveSpeed = 3;
    int roomOrder = 0;
    public GameObject Ui;
    float Timer;
    float dar =1f;
    bool swipeDone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (swipeDone)
            Timer += Time.deltaTime;

        transform.position = Vector3.Lerp(transform.position, nextPosition, Time.deltaTime * moveSpeed);
        if(roomOrder == 0)
        {
            if (SwipeManager.swipeLeft)
            {
                nextPosition.x = 20f;
                nextPosition.y = -10f;
                roomOrder = 1;
            }
        }
        if (roomOrder == 1)
        {
            Ui.SetActive(false);
            if (SwipeManager.swipeDown)
            {
                nextPosition.x = 20f;
                nextPosition.y = 0f;
                roomOrder = 2;
            }
            if (SwipeManager.swipeUp)
            {
                
                nextPosition.x = 20f;
                nextPosition.y = -20f;
                roomOrder = 3;
            }
            if (SwipeManager.swipeLeft)
            {
                Application.Quit();
            }
        }
        if (roomOrder == 3)
        {
            if (SwipeManager.swipeDown)
            {
                nextPosition.x = 20f;
                nextPosition.y = -10f;
                roomOrder = 1;
            }
        }
        if (roomOrder == 2)
        {
            Ui.SetActive(true);
            if (SwipeManager.swipeUp)
            {
                nextPosition.x = 20f;
                nextPosition.y = -10f;
                roomOrder = 1;
                Timer = 0;
                swipeDone = false;
            }
            
            if (SwipeManager.swipeLeft) { SceneManager.LoadScene("levels"); }
            if (SwipeManager.swipeDown) 
            {
                swipeDone = true;
                    if(Timer>dar)
                {
                    SceneManager.LoadScene("levels 1");
                }
             }
        }



    }
    public void onIntro()
    {
        nextPosition.x = 20f;
        nextPosition.y = -10f;
    }
    public void onplay()
    {
        nextPosition.x = 20f;
        nextPosition.y = 0f;
    }
    public void onSettings()
    {
        nextPosition.x = 20f;
        nextPosition.y = -20f;
    }
    public void exit()
    {
        
    }
}
