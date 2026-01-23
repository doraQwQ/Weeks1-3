using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public Camera gameCamera;
    private Vector3 mousePosition;
    public float rotateSpeed = 50f;
    public float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePosition=transform.position; 
        bool leftIsHeld = Mouse.current.leftButton.isPressed;
        if (leftIsHeld)
        {
            transform.eulerAngles+= transform.forward * rotateSpeed * Time.deltaTime;
            Debug.Log("Left mouse is held");
        }

        bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        if (leftIsPressed)
        {
            Debug.Log("Left mouse is pressed.");
        }

        bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        if (leftIsReleased)
        {
            Debug.Log("Left mouse is released.");
        }
        bool upIsHeld= Keyboard.current.upArrowKey.isPressed;
        if (upIsHeld)
        {
            Debug.Log("Up Arrow key is held");
            transform.position += transform.up * moveSpeed*Time.deltaTime;
            
        }
        bool downIsHeld = Keyboard.current.downArrowKey.isPressed;
        if (upIsHeld)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
            Debug.Log("Down Arrow key is held");
        }
        bool rightIsHeld = Keyboard.current.rightArrowKey.isPressed;
        if (rightIsHeld)
        {
            transform.eulerAngles -= transform.forward * rotateSpeed * Time.deltaTime;
        }
        transform.position = mousePosition;
    }   
}
