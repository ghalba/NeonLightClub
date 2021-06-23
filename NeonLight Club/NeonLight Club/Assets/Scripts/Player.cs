using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public static bool Collided;
    public static  Vector3 Direction;
    public Transform PivotRight, PivotLeft, PivotUp, PivotDown;
    public float Speed;
    public float Distance;
    public static int Stars_Collected;
    public static bool Death;
    public Vector3 theScale;
    public float animSpeed = 1f;
    public GameObject Vfx;


    void Start()
    {
        theScale.x = 0f;
        theScale.y = 0.01f;
        theScale.z = 0f;

    }

    void Update()
    {
        Debug.Log("Numbers of stars COllected is " + Stars_Collected);
        PlayerIsDead();
        if (Direction == Vector3.zero)
        {
            if (SwipeManager.swipeRight && CheckRight())
            {
                {
                    Direction = Vector3.right;
                    theScale.x = 0.01f;
                }
            }
            if (SwipeManager.swipeUp && CheckUp())
            {
                {
                    Direction = Vector3.up;
                    theScale.x = 0.01f;
                }
               

            }
            if (SwipeManager.swipeLeft && CheckLeft())
            {
                {
                    Direction = Vector3.left;
                    theScale.x = 0.01f;
                }
                   

            }
            if (SwipeManager.swipeDown && CheckDown())
            {
                {
                    Direction = Vector3.down;
                    theScale.x = 0.01f;
                }
                   


            }
            return;
        }
        Vfx.transform.localScale = Vector3.Lerp(transform.localScale, theScale, Time.deltaTime * animSpeed);
        transform.Translate(Direction * Time.deltaTime * Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Star")
        {
            Direction = Vector3.zero;
            theScale.x = 0f;

        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        Collided =false;
    }

    public bool CheckLeft()
    {
        RaycastHit2D hit = Physics2D.Raycast(PivotLeft.position, -PivotLeft.right, Distance);
        if (hit.collider.tag != "star")
            return false;
        else
            return true;
    }

    public bool CheckRight()
    {
        RaycastHit2D hit1 = Physics2D.Raycast(PivotRight.position, PivotRight.right, Distance);
        if (hit1.collider.tag != "star")
            return false;
        else
            return true;
    }

    public bool CheckUp()
    {
        RaycastHit2D hit2 = Physics2D.Raycast(PivotUp.position, PivotUp.up, Distance);

        if (hit2.collider.tag != "star")
        {
            
            return false;
        }
            
        else
            return true;
    }

    public bool CheckDown()
    {
        RaycastHit2D hit3 = Physics2D.Raycast(PivotDown.position, -PivotDown.up, Distance);
        if (hit3.collider.tag != "star")
            return false;
        else
            return true;
    }

    public void PlayerIsDead()
    {
        if (Death)
        {
            Direction = Vector3.zero;
            transform.position = new Vector2(-0.53f, 7.99f);
        }
    }
}