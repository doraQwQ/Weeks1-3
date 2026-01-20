using UnityEditor;
using UnityEngine;
//Learn how to use animation curve.
public class Pulser : MonoBehaviour
{
    public AnimationCurve curve;
    private float progress = 0;
    public float output;
    public float duration = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime/duration;
        output = curve.Evaluate(progress);
        transform.localScale = Vector3.one*output;
        if (progress>4f)
        {
            progress = 0f;
        }
        
    }
}
