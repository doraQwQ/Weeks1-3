using UnityEngine;

public class Cat1 : MonoBehaviour
{
    public float xSpeed = 0.4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 catPos = transform.position;
        catPos.x+=xSpeed*Time.deltaTime;
        if (catPos.x > 8.2f)
        {
            xSpeed *= -1;
        } else if(catPos.x< 7.5f)
        {
            xSpeed *= -1;
        }
        transform.position = catPos;
    }
}
