using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRightPoint : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameObject backGroundObject = GameObject.Find("BackGroundPrefab");
        SpriteRenderer sr = backGroundObject.GetComponent<SpriteRenderer>();

        float x = sr.bounds.size.x;

        Vector2 targetPos = backGroundObject.transform.position;

        Vector2 thisPos = transform.position;

        thisPos.x = targetPos.x + x / 2;

        transform.position = thisPos;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
