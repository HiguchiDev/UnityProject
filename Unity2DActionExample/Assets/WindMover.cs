using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMover : MonoBehaviour {
    private List<Wind> winds = new List<Wind>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach(Wind wind in winds){
            //wind.
        }
		
	}

    void add(Wind wind){
        this.winds.Add(wind);
    }
}
