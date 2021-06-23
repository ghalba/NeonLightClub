using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playerr : MonoBehaviour
{
    public static bool Collided;
    public static  Vector3 Direction;
    public Transform PivotRight, PivotLeft, PivotUp, PivotDown;
    public float Speed;
    public float Distance;
    public static int Stars_Collected;
    public static bool Death;
    public int Current_Direction;
    public GameObject Vfx;
    public Vector3 theScale;
    public float animSpeed = 1f;
    public Vector3 rotationVfx;
    public static int Current_Level=0;
    public GameObject sfx;


    void Start()
    {
        theScale.x = 0f;
        theScale.y = 0.01f;
        theScale.z = 0f;
    }

    void Update()
    {
        
        PlayerIsDead();
        if (Direction == Vector3.zero)
        {
            if (SwipeManager.swipeRight && CheckRight())
            { 
                Direction = Vector3.right;
                Current_Direction = 1;
                theScale.x = 0.025f;
                rotationVfx.z = 0f;
                Instantiate(sfx, transform);

            }
            if (SwipeManager.swipeUp && CheckUp())
            {

                Direction = Vector3.up;
                Current_Direction = 2;
                theScale.x = 0.025f;
                rotationVfx.z = 90f;
                Instantiate(sfx, transform);

            }
            if (SwipeManager.swipeLeft && CheckLeft())
            {
                Direction = Vector3.left;
                Current_Direction = 3;
                theScale.x = 0.025f;
                Instantiate(sfx, transform);
                rotationVfx.z = 180f;


            }
            if (SwipeManager.swipeDown && CheckDown())
            {
                 Direction = Vector3.down;
                 Current_Direction = 4;
                theScale.x = 0.025f;
                rotationVfx.z = -90f;
                Instantiate(sfx, transform);



            }
            return;
        }
        StopPlayer();
        Vfx.transform.eulerAngles = rotationVfx;
        Vfx.transform.localScale = Vector3.Lerp(Vfx.transform.localScale, theScale, Time.deltaTime * animSpeed);
        transform.Translate(Direction * Time.deltaTime * Speed);
    }


    public bool CheckLeft()
    {
        if (Physics2D.Raycast(PivotLeft.position, -PivotLeft.right, Distance))
            return false;
        else
            return true;
    }

    public bool CheckRight()
    {
        if (Physics2D.Raycast(PivotRight.position, PivotRight.right, Distance))
            return false;
        else
            return true;
    }

    public bool CheckUp()
    {
        if (Physics2D.Raycast(PivotUp.position, PivotUp.up, Distance))
            return false;
        else
            return true;
    }

    public bool CheckDown()
    {
        if (Physics2D.Raycast(PivotDown.position, -PivotDown.up, Distance))
            return false;
        else
            return true;
    }

    public void PlayerIsDead()
    {
        if (Death)
        {
            Direction = Vector3.zero;
        }
    }
    public void StopPlayer()
    {
        RaycastHit2D Right_Hit = Physics2D.Raycast(PivotRight.position, PivotRight.right, Distance);
        RaycastHit2D Left_Hit = Physics2D.Raycast(PivotLeft.position, -PivotLeft.right, Distance);
        RaycastHit2D Up_Hit = Physics2D.Raycast(PivotUp.position, PivotUp.up, Distance);
        RaycastHit2D Down_Hit = Physics2D.Raycast(PivotDown.position, -PivotDown.up, Distance);

       
        ///////////////////
        if (Current_Direction == 1 && Right_Hit && (Right_Hit.collider.tag == "wall"  || Right_Hit.collider.tag == "Closed_Door") )//Right
        {
            Direction = Vector3.zero;
            theScale.x = 0f;
        }
        if (Current_Direction == 2 && Up_Hit && (Up_Hit.collider.tag == "wall" || Up_Hit.collider.tag == "Closed_Door"))//Up
        {
            Direction = Vector3.zero;
            theScale.x = 0f;
        }
        if (Current_Direction == 3 && Left_Hit && (Left_Hit.collider.tag == "wall" || Left_Hit.collider.tag == "Closed_Door") )//Left
        {
            Direction = Vector3.zero;
            theScale.x = 0f;
        }
        if (Current_Direction == 4 && Down_Hit && (Down_Hit.collider.tag == "wall" || Down_Hit.collider.tag == "Closed_Door"))//Down
        {
            Direction = Vector3.zero;
            theScale.x = 0f;
        }
    }

    

}
