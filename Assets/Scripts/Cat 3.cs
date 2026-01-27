using System.Security.Cryptography;
using UnityEngine;
using static UnityEditor.Rendering.CameraUI;

public class Cat3 : MonoBehaviour
{
    public Animation curve;
    public float duration;
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
        //end = curve.Evaluate(progress);

        //transform.localScale = Vector3.one * end;
    }
}
