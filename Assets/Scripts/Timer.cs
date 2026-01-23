using UnityEngine;

public class Timer : MonoBehaviour
{
    public float rotateSpeed=-130f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 iHATEUNITY = transform.eulerAngles;
        iHATEUNITY.z +=rotateSpeed * Time.deltaTime;
        transform.eulerAngles = iHATEUNITY;
    }
}
