using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

/* Understand the most, make the formate for writing a script in Unity, as well as how to
 * let differnt components function together
 */
public class Hider : MonoBehaviour
{
    public Vector3 hidePosition;
    public float hideDistance;
    public Camera gameCamera;
    public float waitDuriation;
    public float timePassed=0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if(timePassed > waitDuriation)
        {
            transform.position = hidePosition;
        }
        //Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        //Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        //worldMousePosition.z = 0; 
        //float distanceToMouse = Vector3.Distance(currentMousePosition, transform.position);
        //if(distanceToMouse < hideDistance)
        //{
        //    transform.position = hidePosition;
        //}
    }
}
