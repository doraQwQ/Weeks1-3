using System.Xml.Schema;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class Chaser : MonoBehaviour
{   
    public int xMax;
    public int xMin;
    public int speed;
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Using the camera tp cpnvert the mouse posiiton from pixel to gameObject
        //Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        //Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        //worldMousePosition.z = 0;
        //transform.position = worldMousePosition;

        //Screen.width; in pixel coordinate
        //Screen.height; in pixel coordinate
        //gameCamera.WorldToScreenPoint(SomeRandomVector);

        //set xMax to whenever is too far to the right for the player to see
        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;

        //set xMin to whenever is to far left for player to see 
        xMin = 0;
        
        if (xMax < screenTransformPosition.x)
        {
            speed *= -1;
        }

        if (xMin > screenTransformPosition.x)
        {
            speed *= -1;
        }
    
    }
}
