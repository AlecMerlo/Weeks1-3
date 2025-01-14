using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSpeen : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public GameObject arrowHead;
    public GameObject clockCenter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        arrowHead.transform.RotateAround(clockCenter.transform.position, -Vector3.forward, rotationSpeed);
    }
}
