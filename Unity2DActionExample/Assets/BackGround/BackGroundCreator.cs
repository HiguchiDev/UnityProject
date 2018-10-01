using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundCreator : MonoBehaviour {

    private GameObject bottomLineObject;
    private GameObject upLineObject;
    private BottomLineUpdater bottomLineUpdater;
    private UpLineUpdater upLineUpdater;

    private GameObject prefabs;

    // Use this for initialization
    void Start () {

        this.bottomLineObject = GameObject.Find("BottomLine");
        this.bottomLineUpdater = bottomLineObject.GetComponent<BottomLineUpdater>();

        this.upLineObject = GameObject.Find("UpperLine");
        this.upLineUpdater = upLineObject.GetComponent<UpLineUpdater>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!this.bottomLineUpdater.visible)
        {

            prefabs = (GameObject)Resources.Load("BackGroundPrefab");
            GameObject shell = (GameObject)Instantiate(prefabs, new Vector3(0, this.upLineObject.transform.position.y +
               (
                    (
                        upLineObject.transform.position.y - bottomLineObject.transform.position.y
                    ) / 2
               ), 1), Quaternion.identity);

            this.bottomLineUpdater.setBackGroundObject(shell);
            this.upLineUpdater.setBackGroundObject(shell);


        }


    }
}
