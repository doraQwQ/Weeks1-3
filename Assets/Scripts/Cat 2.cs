using UnityEngine;
//This function move the cat's head up and down
public class Cat2 : MonoBehaviour
{
    public float ySpeed = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 catPos2 = transform.position;           // Have the cat's head movenment cycles
        catPos2.y += ySpeed * Time.deltaTime;
        if (catPos2.y > 3.16)
        {
            ySpeed *= -1;
        }
        else if (catPos2.y < 3.05)
        {
            ySpeed *= -1;
        }
        transform.position = catPos2;
    }
}
