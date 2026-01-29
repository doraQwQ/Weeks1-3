using System.Threading;
using UnityEngine;
//This function makes the air move up, then moveing forward and backward.
public class Air : MonoBehaviour
{
    public float xSpeed = 0.4f;
    public float ySpeed = 0.7f;
    public int count = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;              //annimation cycles for the air
        position.x += xSpeed * Time.deltaTime;
        position.y += ySpeed * Time.deltaTime;
        count++;
        if (position.x>1.45f|| position.x < 0.94)           //When x value went extreme,
                                                            //go another direction        
        {
            xSpeed = -xSpeed;
        }
       

        if (count > 400)                                    //A timer for teleporting the air back to lower place
        {
            count = 0;
            position.y = -2.827f;
        }
      
        transform.position = position;
    }
}
