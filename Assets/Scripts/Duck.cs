using UnityEngine;
using UnityEngine.InputSystem;
//This script detects the user mouse distance with the duck distance. 
//If the distance is smaller than a number, the timer will start running
//The duck will move based on the curve locations.
public class Duck : MonoBehaviour
{
    public Camera gameCamera;
    public bool timeIsRunning = false;
    public float timer = 0;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector2 mouseLocation = Mouse.current.position.ReadValue();
        Vector2 currentLocation = gameCamera.WorldToScreenPoint(transform.position);
        float distance = Vector2.Distance(currentLocation, mouseLocation);
        Vector2 newCoord = (transform.position);
        if (distance < 50)
        {
            timeIsRunning = true;
        }else  
        {
            timer = 0;
            timeIsRunning = false;
        }

        if (timeIsRunning)
        {
            timer += 1 * Time.deltaTime;
            newCoord.x = curve.Evaluate(timer);
            transform.position = newCoord;
        }
    }
}
