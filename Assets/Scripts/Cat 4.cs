using UnityEngine;
//This function makes the cat peek one time then disappear.
public class Cat4 : MonoBehaviour
{   
    public AnimationCurve curve;
    public float duration = 5;  
    public float progress = 0f;
    public float end;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / duration;          //have a variable that can control the % of action
        end = curve.Evaluate(progress);

        Vector3 value = transform.position;             //moving the cat up and down
        value.y +=end;          
        value.z = 0;
        transform.position = value;
    }
}
