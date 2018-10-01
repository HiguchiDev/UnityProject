using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpLineUpdater : MonoBehaviour {

    private GameObject backGroundObject;
    private bool visible;
    private SpriteRenderer sr;

    // Use this for initialization
    void Start () {

        backGroundObject = GameObject.Find("BackGroundPrefab");

        sr = backGroundObject.GetComponent<SpriteRenderer>();

        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = backGroundObject.transform.position;

        thisPos.y = (targetPos.y + y / 2);

        transform.position = thisPos;

        this.visible = true;


    }

    public void setBackGroundObject(GameObject gameObject)
    {
        this.backGroundObject = gameObject;
        this.visible = true;
        this.Update();
        sr = backGroundObject.GetComponent<SpriteRenderer>();
    }

    public GameObject getBackGroundObject()
    {
        return this.backGroundObject;


    }

    // Update is called once per frame
    void Update () {
        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = backGroundObject.transform.position;

        thisPos.y = (targetPos.y + y / 2);

        transform.position = thisPos;

    }

    void OnBecameInvisible()
    {
        Vector2 pos = transform.position;

        print("Upper座標" + pos.x + ":" + pos.y);

        this.visible = false;
        print(this.visible);
    }

    void OnBecameVisible()
    {
        Vector2 pos = transform.position;

        print("Upper座標" + pos.x + ":" + pos.y);

        this.visible = true;
        print(this.visible);
    }

}
