using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogSpeen : MonoBehaviour
{
    public AnimationCurve curve;
    public float speed;
    float t;
    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        t %= 1;
        transform.Rotate(Vector3.forward * Time.deltaTime * speed * curve.Evaluate(t));
    }
}
