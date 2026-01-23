using UnityEngine;
using UnityEngine.InputSystem;

public class Looker : MonoBehaviour
{
    public float rotationSpeed=5f;
    public float zMax = 10f;
    public float zMin = -10f;
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        //If we want to move the object, we would use transform.position;
        //transform.rotation is more complex, so we dont use this;
        /* One way of rotating using eurler angles
        currentRotation.z += rotationSpeed * Time.deltaTime;
        transform.eulerAngles = currentRotation;
        if (currentRotation.z > zMax)
        {
            rotationSpeed *= -1;
        }
        else if (currentRotation.z < zMin)
        {
            rotationSpeed *= -1;
        }
        Debug.Log(transform.eulerAngles);
        */

        /*the console value is different than inspector.
         * Eurlerangle goes from 0 -360
           inspector shows -180 to 180 */
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition= gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        transform.up = worldMousePosition-transform.position;
        transform.position += transform.up * 1f * Time.deltaTime;
    }
}
