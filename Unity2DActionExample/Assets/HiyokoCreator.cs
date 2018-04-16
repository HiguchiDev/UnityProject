using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoCreator : MonoBehaviour {

    GameObject prefab;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 30; i++) {
            for (int j = 0; j < 30; j++) {
                prefab = (GameObject)Resources.Load("HiyokoPrefab");
                float posX = (i * 0.3f);
                float posY = (j * 0.3f);
                float posZ = -0.1f;

                Vector3 pos = new Vector3(posX, posY, posZ);

                // プレハブからインスタンスを生成
                GameObject obj = (GameObject)Instantiate(prefab, pos, Quaternion.identity);
            }
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
