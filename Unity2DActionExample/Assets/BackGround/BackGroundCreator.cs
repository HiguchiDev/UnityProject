using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundCreator : MonoBehaviour {

    private GameObject upLineObject;

    private UpLineUpdater upLineUpdater;

    private GameObject prefabs;

    // Use this for initialization
    void Start () {
    
        this.upLineObject = GameObject.Find("UpperLine");
        this.upLineUpdater = upLineObject.GetComponent<UpLineUpdater>();
    }
	
	// Update is called once per frame
	void Update () {
        print("BackGroundCreator call Update");
        if (this.upLineUpdater.getVisivle())
        {

            prefabs = (GameObject)Resources.Load("BackGroundPrefab");
            GameObject shell = (GameObject)Instantiate(prefabs,
                                                       new Vector3(0, 
                                                                   this.upLineObject.transform.position.y + (prefabs.GetComponent<SpriteRenderer>().bounds.size.y / 2)
               , 1), Quaternion.identity);

            print("upLineObj:y:" + this.upLineObject.transform.position.y);
            print("prefabs:y:" + prefabs.GetComponent<SpriteRenderer>().bounds.size.y / 2);

            this.upLineUpdater.setBackGroundObject(shell);


        }


    }
}
