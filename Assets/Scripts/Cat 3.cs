using System.Security.Cryptography;
using UnityEngine;
using static UnityEditor.Rendering.CameraUI;
using UnityEditor;
using System.Collections;
//This function makes the cat fade in and out based on the animation curve
public class Cat3 : MonoBehaviour
{
    public AnimationCurve curve;
    public float duration = 10;
    public float progress = 0f;
    public float end;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / duration;
        end = curve.Evaluate(progress);

        //end is the y value; 
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, end);

    }
}
