using UnityEngine;
using System.Collections;

public class PlayerBulletAutoMover : MonoBehaviour
{
    void Update()
    {
        //print("BackGroundAutoUpdater call Update");

        Vector3 pos = transform.position;

        pos.y += 0.075f;



        transform.position = pos;



    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
