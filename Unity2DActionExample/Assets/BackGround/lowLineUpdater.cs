using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowLineUpdater : MonoBehaviour {

    private GameObject gameObject;

    // Use this for initialization
    void Start () {
        gameObject = GameObject.Find("backGround");

        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();

        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = gameObject.transform.position;

        thisPos.y = targetPos.y - y / 2;

        transform.position = thisPos;
    }
	
	// Update is called once per frame
	void Update () {
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();

        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = gameObject.transform.position;

        thisPos.y = targetPos.y - y / 2;

        transform.position = thisPos;


    }
}
