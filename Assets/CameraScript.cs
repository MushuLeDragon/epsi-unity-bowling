using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Ball;
    private float offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.z - Ball.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Ball.transform.position.z + offset);  
    }
}
