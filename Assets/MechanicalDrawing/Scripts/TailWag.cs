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
        t += Time.deltaTime;
        transform.RotateAround(tailBase.transform.position, Vector3.up, Time.deltaTime * speed);
    }
}
