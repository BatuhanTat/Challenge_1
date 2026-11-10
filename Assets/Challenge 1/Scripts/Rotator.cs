using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float dönmeHızı = 1000f;


    void Update()
    {
        //transform.Rotate(Vector3.forward, dönmeHızı * Time.deltaTime);

        transform.Rotate(0, 0, 30);
    }
}
