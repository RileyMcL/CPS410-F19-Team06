using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Touch myTouch = Input.GetTouch(0);
        Touch[] myTouches = Input.touches;
        for(int i = 0; i < Input.touchCount; i++){
            //do stuff w/ touches
        }

    }
}
