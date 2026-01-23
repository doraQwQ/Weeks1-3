using NUnit.Framework;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class Controller : MonoBehaviour
{
    public Camera gameCamera;
    private Vector3 mousePosition;
    public float rotateSpeed = 50f;
    public float moveSpeed = 10f;
    public SpriteRenderer spriteRenderer;
    public Color startingcolor;

    public List<SpriteRenderer> controllableRenderer;
    public List<Transform> controlledTransforms;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer.color = Color.cyan;
        controlledTransforms.Add(transform);
        //spriteRebderer.sprite
        //spriteRenderer.bounds.Contains();       //Detects whether a position is within the bounds of the sprite
        //can be used for collision detection
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        bool isLeftMousePressed = Mouse.current.leftButton.isPressed;
        if (isLeftMousePressed)
        {       //checking if the rdnderere are on top of the sprite, if so, add to the controlled transforms list

            for (int i = 0; i < controllableRenderer.Count; i++)
            {
                bool isHovered = controllableRenderer[i].bounds.Contains(worldMousePosition);
                if (isHovered)
                {
                    controlledTransforms.Add(controllableRenderer[i].transform);
                }
                
            }
        }
         
        for(int i=0; i< controlledTransforms.Count; i++)
        {
          Transform currentTransform = controlledTransforms[i];
        
            bool leftIsHeld = Mouse.current.leftButton.isPressed;
            if (leftIsHeld)
            {
                currentTransform.eulerAngles+= currentTransform.forward * rotateSpeed * Time.deltaTime;
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
                currentTransform.position += currentTransform.up * moveSpeed*Time.deltaTime;
            
            }
            bool downIsHeld = Keyboard.current.downArrowKey.isPressed;
            if (upIsHeld)
            {
                currentTransform.position -= currentTransform.up * moveSpeed * Time.deltaTime;
                Debug.Log("Down Arrow key is held");
            }
            bool rightIsHeld = Keyboard.current.rightArrowKey.isPressed;
            if (rightIsHeld)
            {
                currentTransform.eulerAngles -= currentTransform.forward * rotateSpeed * Time.deltaTime;
            }
        }
    }   
}
