using UnityEngine;
/*
 * add a sprtie. make a timer and add to 1 using a public speed variable,
 * when timer reaches 1, reset timer to 0
 */
public class Sprite : MonoBehaviour
{
    public float speed = 0.1f;
    public float timer = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += speed*Time.deltaTime;
        if (timer>1.0f)
        {   
            timer = 0.0f;
        }
        
    }
}
