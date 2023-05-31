using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{

    private Vector2 initialTouchPosition;
    private Vector2 endTouchPosition;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initialized");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            initialTouchPosition = touch.position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            Touch touch = Input.GetTouch(0);
            endTouchPosition = touch.position;

            CheckSwipe();
        }
        
    }
    private void CheckSwipe()
    {
        if (initialTouchPosition.x < endTouchPosition.x)
        {
            Debug.Log("Swiped right");
        }
        else
        {
            Debug.Log("Swiped left");
        }
    }
}
