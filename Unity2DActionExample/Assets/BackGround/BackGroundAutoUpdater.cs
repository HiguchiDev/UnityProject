using UnityEngine;
using System.Collections;

public class BackGroundAutoUpdater : MonoBehaviour {

    void Update()
    {
        //print("BackGroundAutoUpdater call Update");

        Vector3 pos = transform.position;

        pos.y += -0.025f;



        transform.position = pos;



    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
