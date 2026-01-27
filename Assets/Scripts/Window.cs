using UnityEngine;
using UnityEngine.InputSystem;
//This function changes the size of the window based on the mouse position with 1,1,1
public class Window  : MonoBehaviour
{
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0f;
        float distance = Vector3.Distance(worldMousePosition, Vector3.one);
        if(distance < 4f)
        {
            transform.localScale = ((distance * Vector3.one) / 2) / 2;
        }
        
            
    }
}
