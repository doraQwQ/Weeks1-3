using UnityEngine;
//Coding Gym 2 Teleport
/*Adding a sprite to the scene, using a timer that counts up to 3s.
When timer is up, restart the timer and change the location of sprite
to a random location on the screen*/
public class Cat : MonoBehaviour
{
    public float timer ;
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer+Time.deltaTime;
        if (timer > 3)
        {
            transform.position = Random.insideUnitCircle*8;
            timer = 0;
        }
    }
}
