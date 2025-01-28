using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailWag : MonoBehaviour
{
    public Transform tailBase;
    public float speed;
    float t;
    // Update is called once per frame
    void Update()
    {
        // a forever rotation, it will look fine on screen so it doesn't matter if it doesn't switch directions
        t += Time.deltaTime;
        transform.RotateAround(tailBase.transform.position, Vector3.up, Time.deltaTime * speed);
    }
}
