using UnityEngine;
//Bouncing ball Coding gym
/* Make a circle that moves in X and Y, and bounces at the edges of the screen.
  */
public class Ball : MonoBehaviour
{
    private float xValue;
    private float yValue;
    public float xSpeed=0.001f;
    public float ySpeed=0.002f;
    public Camera gameCamera;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 location = gameCamera.WorldToScreenPoint(transform.position);   //Get the location of circle to be in pixel
        xValue = Screen.width;
        yValue = Screen.height;

        location.x += xSpeed;
        location.y += ySpeed;

        if (location.x > xValue)
        {
            xSpeed *= -1;
        }
        if (location.x < 0)
        {
            xSpeed *= -1;
        }

        if (location.y > yValue)
        {
            ySpeed *= -1;
        }
        if (location.y < 0)
        {
            ySpeed *= -1;
        }
        
        Vector3 worldLocation = gameCamera.ScreenToWorldPoint(location); //Convert back to world coordinate
        worldLocation.z = 0; 
        transform.position = worldLocation;
    }
}
