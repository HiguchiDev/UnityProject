using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomLineUpdater : MonoBehaviour {

    private GameObject backGroundObject;
    public bool visible;

    // Use this for initialization
    void Start () {
        backGroundObject = GameObject.Find("BackGroundPrefab");

        SpriteRenderer sr = backGroundObject.GetComponent<SpriteRenderer>();

        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = backGroundObject.transform.position;

        thisPos.y = targetPos.y - y / 2;

        transform.position = thisPos;

        visible = true;

    }
	
	// Update is called once per frame
	void Update () {
        SpriteRenderer sr = backGroundObject.GetComponent<SpriteRenderer>();

        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = backGroundObject.transform.position;

        thisPos.y = targetPos.y - y / 2;

        transform.position = thisPos;


    }

    public void setBackGroundObject(GameObject gameObject)
    {
        this.backGroundObject = gameObject;
    }

    void OnBecameVisible()
    {
        Vector2 pos = transform.position;

        print("Bottom!座標OnBecameVisible" + pos.x + ":" + pos.y);

        this.visible = true;
        print(this.visible);
    }

    void OnBecameInvisible()
    {
        Vector2 pos = transform.position;

        print("Bottom座標OnBecameInvisible" + pos.x + ":" + pos.y);

        this.visible = false;
        print(this.visible);
    }
}
