using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControls : MonoBehaviour
{
    private bool Tap, SwipeLeft, SwipeRight, SwipeUp, SwipeDown;
    private Vector2 StartTouch, SwipeDelta;

    private void Update()
    {
        Tap = SwipeLeft= SwipeUp= SwipeDown= SwipeRight = false;

        if (Input.GetMouseButtonDown(0))
        {
            Tap = true;
            StartTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) //OR DOWN
        {
            Reset();
        }
    }

    private void Reset()
    {
        StartTouch = SwipeDelta =Vector2.zero;
    }

    public Vector2 swipeDelta { get { return SwipeDelta; } }
    public bool swipeLeft { get{ return SwipeLeft; } }
    public bool swipeRight { get { return SwipeRight; } }
    public bool swipeUp { get { return SwipeUp; } }
    public bool swipeDown { get { return SwipeDown; } }





}
