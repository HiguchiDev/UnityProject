using UnityEngine;
using System.Collections;
using Assets;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private const float MOVE_SPEED = 0.75f;
    private GameObject enemyMoveStopPoint;
    Vector3 velocity = Vector3.zero;
    private int flameCount;

    // Updateの前に1回だけ呼ばれるメソッド
    void Start()
    {
        enemyMoveStopPoint = GameObject.Find("EnemyMoveStopPoint");
        // Rigidbody2Dをキャッシュする
        rb2d = GetComponent<Rigidbody2D>();

        this.flameCount = 0;

    }

    // シーン中にフレーム毎に呼ばれるメソッド
    void Update()
    {
        // = new Vector2(0, -MOVE_SPEED);

        Vector2 vector2;


            Vector3 vector3;
            vector3 = Vector3.SmoothDamp(transform.position,
                                            enemyMoveStopPoint.transform.position,
                                            ref velocity,
                                            MOVE_SPEED);
        vector2 = new Vector2(transform.position.x, -vector3.y);

        if (transform.position.y > enemyMoveStopPoint.transform.position.y){

            if (++flameCount == 60)
            {
                GameObject prefabs = (GameObject)Resources.Load("WindPrefab");
                GameObject shell = (GameObject)Instantiate(prefabs,
                                                           new Vector3(this.transform.position.x,
                                                                       this.transform.position.y,
                                                                       this.transform.position.z),
                                                           Quaternion.identity);
                this.flameCount = 0;

                print("a");
            }

        }
        else{
            vector2 = new Vector2(0, 0);
        }

        rb2d.velocity = velocity;
    }
}
