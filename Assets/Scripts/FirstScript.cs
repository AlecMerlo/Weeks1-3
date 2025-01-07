using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (pos.x > Screen.width || pos.x < 0)
        {
            speed *= -1;
        }
        pos.x += speed;

        transform.position = pos;
        
    }
}
