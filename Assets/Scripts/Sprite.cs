using UnityEngine;
using static UnityEditor.Rendering.CameraUI;
/*Coding gym 2 Floating on the ocean 
 * add a sprite. make a timer and add to 1 using a public speed variable,
 * when timer reaches 1, reset timer to 0
 */
/* Declare a public animation Curve use this curve with timer to change the sprite's y location,
 * let the sprite movenment looks like floating up and down in water
 */ 
public class Sprite : MonoBehaviour
{
    public float speed = 0.1f;
    public float timer = 0.0f;
    public AnimationCurve curve;
    public float end;
    private float processing;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        end = curve.Evaluate(timer);
        //timer += speed*Time.deltaTime;
        transform.position = new Vector3(transform.position.x, end, 0);
        //transform.localScale = Vector3.one * end;//this one changes the scale of the sprite
        //if (timer>1.0f)
        //{   
        //    timer = 0.0f;
        //}
        if (timer> 2.0f)
        {        
            timer = 0.0f;
        }
        
    }
}
