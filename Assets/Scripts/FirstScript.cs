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
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeInTheWorld = new Vector2();
        screenSizeInTheWorld = Camera.main.ScreenToWorldPoint(screenSize);
        if (pos.x > screenSizeInTheWorld.x)
        {
            speed = -0.1f;
        }
        else if (pos.x < -screenSizeInTheWorld.x)
        {
            speed = 0.1f;
        }
        pos.x += speed;

        transform.position = pos;
        
    }
}
