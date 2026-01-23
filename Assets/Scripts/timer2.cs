using UnityEngine;

public class timer2 : MonoBehaviour
{
    public float rotateSpeed = -30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 iHATEUNITY2 = transform.eulerAngles;
        iHATEUNITY2.z += rotateSpeed * Time.deltaTime;
        transform.eulerAngles = iHATEUNITY2;
    }
}
