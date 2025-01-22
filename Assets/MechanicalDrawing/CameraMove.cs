using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x < (Screen.width / 2) - (Screen.width / 4) && transform.rotation.y > -0.2f * Mathf.Deg2Rad)
        {
            transform.Rotate(0, -0.1f * Mathf.Deg2Rad, 0);
        }
        else if (Input.mousePosition.x > (Screen.width / 2) + (Screen.width / 4) && transform.rotation.y < 0.2f * Mathf.Deg2Rad)
        {
            transform.Rotate(0, 0.1f * Mathf.Deg2Rad, 0);
        }
        if (Input.mousePosition.y < (Screen.height / 2) - (Screen.height / 4) && transform.rotation.x < 0.2f * Mathf.Deg2Rad)
        {
            transform.Rotate(0.1f * Mathf.Deg2Rad, 0, 0);
        }
        else if (Input.mousePosition.y > (Screen.height / 2) + (Screen.height / 4) && transform.rotation.x > -0.2f * Mathf.Deg2Rad)
        {
            transform.Rotate(-0.1f * Mathf.Deg2Rad, 0, 0);
        }
    }
}
