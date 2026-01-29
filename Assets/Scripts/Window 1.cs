using UnityEngine;
using static UnityEditor.Rendering.CameraUI;
//This function makes the window move to random position 
public class Window1 : MonoBehaviour
{
    public Vector3 newPosition;
    public float duration = 3;
    public float progress = 0;
    public Vector3 output;
    public bool value = true;
    public Vector3 currentPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (progress>1)//when the window reach the new coordinate
        {
            value = true;
            progress = 0;
        }
        if (value)          //set the first value for lerp
        {
            newPosition = new Vector3(Random.Range(-9f, 9f), Random.Range(-5f, 5f), 0f);
            currentPos = transform.position;
            value = false;
        }
        progress += Time.deltaTime / duration;
        output = Vector3.Lerp(currentPos, newPosition, progress);
        transform.position = output;



    }
}
