using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour
{
    private bool tap, swipeleft, swiperight, swipeup, swipedown;
    private Vector2 starttouch, swipedelta;



    public bool Tap { get { return tap; } }
    public bool SwipeLeft { get { return swipeleft; } }
    public bool SwipeRight { get { return swiperight; } }
    public bool SwipeUp { get { return swipeup; } }
    public bool SwipeDown { get { return swipedown; } }
    public Vector2 SwipeDelta { get { return swipedelta; } }



    private bool isdragging = false;



    void Update()
    {
        tap = swipeleft = swiperight = swipeup = swipedown = false;

        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                isdragging = true;
                tap = true;
                starttouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isdragging = false;
                reset();
            }
        }

        // Calculate the distance 
        swipedelta = Vector2.zero;
        if (isdragging)
        {
            if (Input.touches.Length > 0)
            {
                swipedelta = Input.touches[0].position - starttouch;
            }
        }


        //swipe when we have swapped on mobile
        if (swipedelta.magnitude > 125)
        {
            //checking which direction swipe has done
            float x = swipedelta.x;
            float y = swipedelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                //left  or right 
                if (x < 0)
                {
                    swipeleft = true;
                }
                else
                {
                    swiperight = true;
                }
            }
            else
            {
                //up or down
                if (y < 0)
                {
                    swipedown = true;
                }
                else
                {
                    swipeup = true;
                }
            }
            reset();
        }

    }



    private void reset()
    {
        starttouch = swipedelta = Vector2.zero;
        isdragging = false;
    }
}
