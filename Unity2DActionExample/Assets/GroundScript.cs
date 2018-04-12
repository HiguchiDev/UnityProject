using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

    public bool visible = false;
	// Use this for initialization
	void Start () {
        this.visible = false;

    }
	
	// Update is called once per frame
	void Update () {

    }
    
    void OnBecameInvisible()
    {
        this.visible = false;
    }

    void OnBecameVisible()
    {
        this.visible = true;
    }


    public bool isVisible()
    {
        return this.visible;
    }
}
