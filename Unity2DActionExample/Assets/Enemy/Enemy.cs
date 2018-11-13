using UnityEngine;
using System.Collections;
using Assets;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private const float MOVE_SPEED = 0.5f;
    private GameObject enemyMoveStopPoint;

    // Updateの前に1回だけ呼ばれるメソッド
    void Start()
    {
        enemyMoveStopPoint = GameObject.Find("EnemyMoveStopPoint");
        // Rigidbody2Dをキャッシュする
        rb2d = GetComponent<Rigidbody2D>();

    }

    // シーン中にフレーム毎に呼ばれるメソッド
    void Update()
    {
        Vector2 velocity;// = new Vector2(0, -MOVE_SPEED);

        if (transform.position.y > enemyMoveStopPoint.transform.position.y)
        {
            velocity = new Vector2(0, -MOVE_SPEED);
        }
        else{
            velocity = new Vector2(0, 0);
        }

        rb2d.velocity = velocity;
    }
}
