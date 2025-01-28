using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing : MonoBehaviour
{
    public AnimationCurve curve;
    float t;

    // Update is called once per frame
    void Update()
    {
        // scaling up and down to simulate breathing
        t += Time.deltaTime / 5;
        t %= 1;
        // curve will be between 1 and something slightly higher for good scale
        transform.localScale = Vector3.one * curve.Evaluate(t);
    }
}
