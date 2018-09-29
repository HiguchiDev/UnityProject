using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCreator : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        Camera camera = GetComponent<Camera>();
        /*
        Vector2 pos = Camera.main.ViewportToWorldPoint(Vector2.zero);


        Vector3 pos = new Vector3(width, height, posZ);

        // プレハブからインスタンスを生成
        GameObject obj = (GameObject)Instantiate(prefab, pos, Quaternion.identity);
        */
    }



    void Update()
    {

    }

}
