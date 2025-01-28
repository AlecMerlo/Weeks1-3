using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogSpeen : MonoBehaviour
{
    public AnimationCurve curve;
    public float speed;
    public float curveSpeed;
    float t;
    // Update is called once per frame
    void Update()
    {
        // rotates based on time
        t += Time.deltaTime * curveSpeed;
        t %= 1;
        transform.Rotate(Vector3.forward * Time.deltaTime * speed * curve.Evaluate(t));
    }
}
