using System.Threading;
using UnityEngine;

public class Air : MonoBehaviour
{
    public float xSpeed = 0.4f;
    public float ySpeed = 0.7f;
    public int count = 0;
    //starting x pos = ?
    //starting y pos =-0.19
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x += xSpeed * Time.deltaTime;
        position.y += ySpeed * Time.deltaTime;
        count++;
        if (position.x>1.45f|| position.x < 0.94)
        {
            xSpeed = -xSpeed;
        }
       

        if (count > 400)
        {
            count = 0;
            position.y = -2.827f;
        }
      
        transform.position = position;
    }
}
