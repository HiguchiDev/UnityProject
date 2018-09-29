using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upLineUpdater : MonoBehaviour {

    private GameObject gameObject;
    private bool visible;
    private SpriteRenderer sr;

    // Use this for initialization
    void Start () {

        gameObject = GameObject.Find("backGround");

        sr = gameObject.GetComponent<SpriteRenderer>();

        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = gameObject.transform.position;

        thisPos.y = (targetPos.y + y / 2);

        transform.position = thisPos;

        this.visible = true;


    }
	
	// Update is called once per frame
	void Update () {
        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = gameObject.transform.position;

        thisPos.y = (targetPos.y + y / 2);

        transform.position = thisPos;

    }

    void OnBecameInvisible()
    {
        Vector2 pos = transform.position;

        print("座標" + pos.x + ":" + pos.y);

        this.visible = false;
        print(this.visible);
    }
}
