using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum SIDE { left, right, mid }

public class playermotion : MonoBehaviour
{
    public SIDE midside = SIDE.mid;
    float newxpos = 0f;
    public float xvalue;

    public swipe swipecontrols;
    public CharacterController player;
    private Vector3 desiredposition;

    void Start()
    {
        player = GetComponent<CharacterController>();
        transform.position = Vector3.zero
;
    }
    void Update()
    {
        if (swipecontrols.SwipeLeft)
        {
            if (midside == SIDE.mid)
            {
                newxpos = -xvalue;
                midside = SIDE.left;
            }
            else if (midside == SIDE.right)
            {
                newxpos = 0;
                midside = SIDE.mid;
            }
        }

        if (swipecontrols.SwipeRight)
        {
            if (midside == SIDE.mid)
            {
                newxpos = xvalue;
                midside = SIDE.right;
            }
            else if (midside == SIDE.left)
            {
                newxpos = 0;
                midside = SIDE.mid;
            }
        }

        player.Move((newxpos - transform.position.x) * Vector3.right);
        //if (swipecontrols.SwipeUp)
        //{
        //    desiredposition = desiredposition + Vector3.up;
        //}
        //if (swipecontrols.SwipeDown)
        //{
        //     desiredposition = desiredposition + Vector3.down;
        // }
        // player.transform.position = Vector3.MoveTowards(player.transform.position, desiredposition, 6f * Time.deltaTime);
        // if (swipecontrols.Tap)
        // {
        //     print("Tap");
        // }
    }
}
