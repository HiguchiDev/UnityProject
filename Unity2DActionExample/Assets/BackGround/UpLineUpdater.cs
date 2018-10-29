using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpLineUpdater : MonoBehaviour {

    private GameObject backGroundObject;
    private bool visible;

    public bool getVisivle(){
        return this.visible;
    }


    private SpriteRenderer sr;

    // Use this for initialization
    void Start () {

        backGroundObject = GameObject.Find("BackGroundPrefab");

        sr = backGroundObject.GetComponent<SpriteRenderer>();

        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = backGroundObject.transform.position;

        thisPos.y = (targetPos.y + y / 2.0f);

        transform.position = thisPos;

        this.visible = true;


    }

    public void setBackGroundObject(GameObject gameObject)
    {
        this.backGroundObject = gameObject;
        this.visible = false;
        this.Update();
        sr = backGroundObject.GetComponent<SpriteRenderer>();
    }

    public GameObject getBackGroundObject()
    {
        return this.backGroundObject;


    }

    // Update is called once per frame
    void Update () {
        print("UpLineUpdater call Update");
        float y = sr.bounds.size.y;

        Vector2 thisPos = transform.position;
        Vector2 targetPos = backGroundObject.transform.position;

        thisPos.y = (targetPos.y + y / 2);

        transform.position = thisPos;

    }


    void OnBecameVisible()
    {
        Vector2 pos = transform.position;



        this.visible = true;
        print("Upper座標" + pos.x + ":" + pos.y + ":" + this.visible);
        print(this.visible);
    }

}
