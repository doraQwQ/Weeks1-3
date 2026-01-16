using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 0.01f;
    public float xMax = 10;
    public float xMin = -10;
    public float value = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x += speed *Time.deltaTime;
        transform.position = moverXPos;
        if (speed > 0)              //acclerating the speed during moving
        {
            speed = speed + 0.01f;
        }else
        {
            speed = speed - 0.01f;
        }

        if (moverXPos.x > xMax)     //bounding the square movenment
        {
            speed = -0.01f;
        }
        else if (moverXPos.x < xMin)
        {
            speed = 0.01f;
        }
    }
}
