using UnityEngine;
using System.Collections;

public class BackGroundAutoUpdater : MonoBehaviour {

    public bool visible = true;

    void Update()
    {
        print("BackGroundAutoUpdater call Update");

        Vector3 pos = transform.position;

        pos.y += -0.1f;



        transform.position = pos;

        

    }


}
