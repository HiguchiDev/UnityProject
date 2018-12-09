using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {

    private const float SPEED = 0.05f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 vector2 = this.transform.position;

        vector2.y -= SPEED;

        this.transform.position = vector2;
		
	}
}
