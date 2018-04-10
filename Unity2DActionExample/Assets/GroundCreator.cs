using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCreator : MonoBehaviour
{
    GameObject prefab;
    List<List<GameObject>> groundList;
    private LinePoint heightPoint;
    private LinePoint bottomPoint;
    GameObject heightLine;
    GameObject bottomLine;
    private const int COLUMN_MAX = 12;
    private const int ROW_MAX = 20;

    // Use this for initialization
    void Start()
    {
        prefab = (GameObject)Resources.Load("GroundPrefab");

        this.groundList = new List<List<GameObject>>();
        for (int i = 0; i <= ROW_MAX; i++)
        {
            this.groundList.Add(new List<GameObject>());
            for (int j = 0; j <= COLUMN_MAX; j++)
            {
                float posX = transform.position.x + (j * prefab.GetComponent<SpriteRenderer>().bounds.size.x);
                float posY = transform.position.y + (i * prefab.GetComponent<SpriteRenderer>().bounds.size.y);
                float posZ = 1.0f;

                Vector3 pos = new Vector3(posX, posY, posZ);

                // プレハブからインスタンスを生成
                GameObject obj = (GameObject)Instantiate(prefab, pos, Quaternion.identity);

                int indexMax = this.groundList.Count - 1;

                this.groundList[indexMax].Add(obj);
            }
        }

    }

    void Update()
    {
        int indexMax = this.groundList.Count - 1;

        if (this.groundList[0][3].GetComponent<GroundScript>().isVisible()) //0番目の値が見たいだけで3はどうでもよい
        {

            this.rotateDown();
            print("rotateDown");
            for (int i = 0; i < this.groundList.Count; i++)
            {
                print( "index : " + i +
                    "xPos : " + this.groundList[i][0].transform.position.x + 
                    "yPos : " + this.groundList[i][0].transform.position.y
                    );

            }
        }
                
        if (this.groundList[indexMax][3].GetComponent<GroundScript>().isVisible()) //最後の値が見たいだけで3はどうでもよい
        {
            this.rotateUp();
            print("rotateUp");

            for (int i = 0; i < this.groundList.Count; i++)
            {
                print("index : " + i +
                    "xPos : " + this.groundList[i][0].transform.position.x +
                    "yPos : " + this.groundList[i][0].transform.position.y
                    );

            }
        }
        
        /*
        for (int i = 0; i < this.groundList.Count; i++)
        {
            Renderer renderer = this.groundList[i][0].GetComponent<Renderer>();

            Color color = new Color(1.0F - ( i * 0.1F), 0.0F, 0.0F);
            renderer.material.color = color;

        }
        */
    }
    /*
    void OnGUI()
    {

        for (int i = 0; i < this.groundList.Count; i++)
        {
            GUI.Label(new Rect(this.groundList[i][0].transform.position.x, this.groundList[i][0].transform.position.y, 100, 100), i.ToString());
        }
    }
    */
        void rotateDown()
    {
        List<GameObject> tempObjects = this.groundList[this.groundList.Count - 1];

        for (int i = this.groundList.Count - 1; i > 0 ; i--)
        {
            this.groundList[i] = this.groundList[i - 1];
        }

        float heightGroundPointY = this.groundList[0][0].transform.position.y;

        for (int j = 0; j <= COLUMN_MAX; j++)
        {
            float posX = transform.position.x + (j * prefab.GetComponent<SpriteRenderer>().bounds.size.x);
            float posY = heightGroundPointY - prefab.GetComponent<SpriteRenderer>().bounds.size.y;
            float posZ = 1.0f;

            Vector3 pos = new Vector3(posX, posY, posZ);

            // プレハブからインスタンスを生成
            this.groundList[0] = tempObjects;
            this.groundList[0][j].transform.position = pos;
        }
    }

    void rotateUp()
    {
        List<GameObject> tempObjects = this.groundList[0];

        this.groundList.RemoveAt(0);
        

        float heightGroundPointY = this.groundList[this.groundList.Count - 1][0].transform.position.y;

        this.groundList.Add(tempObjects);

        for (int j = 0; j <= COLUMN_MAX; j++)
        {
            float posX = transform.position.x + (j * prefab.GetComponent<SpriteRenderer>().bounds.size.x);
            float posY = heightGroundPointY + prefab.GetComponent<SpriteRenderer>().bounds.size.y;
            float posZ = 1.0f;

            Vector3 pos = new Vector3(posX, posY, posZ);

            // プレハブからインスタンスを生成
            this.groundList[this.groundList.Count - 1][j].transform.position = pos;
        }
    }

}
