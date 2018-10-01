using UnityEngine;
using System.Collections;

public class BackGroundAutoUpdater : MonoBehaviour {

    public bool visible = true;

    void Update()
    {


        Vector3 pos = transform.position;

        pos.y += -0.01f;



        transform.position = pos;

        

    }


}
