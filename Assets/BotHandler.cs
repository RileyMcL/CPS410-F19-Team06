using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHandler : MonoBehaviour {
    public static int movespeed = 1;
    public Vector3 userDirection = Vector3.right;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //move
        transform.Translate(userDirection * movespeed * Time.deltaTime);

    }
}
