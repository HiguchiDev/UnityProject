using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoAutoMover : MonoBehaviour {

    // 変数の定義と初期化
    public float flap = 550f;
    public float scroll = 0.01f;
    Rigidbody2D rb2d;
    private Animator Anim;
    private int tempA;
    private int a;
    private float speed;
    MovingDirectionGetter enemyMoveingDirectionGetter;
    public float timeOut;
    private float timeElapsed;
    private bool yakitoriFlag;
    EnumMoveDirection ENUM_DIRECTION;

    // Updateの前に1回だけ呼ばれるメソッド
    void Start()
    {
        yakitoriFlag = false;
        timeOut = 1.5f;
        timeElapsed = 0.0f;
        tempA = 0;
        a = 0;
        Anim = GetComponent<Animator>();
        // Rigidbody2Dをキャッシュする
        rb2d = GetComponent<Rigidbody2D>();

        speed = 0.5f;
        enemyMoveingDirectionGetter = new EnemyMovingDirectionGetter();
        ENUM_DIRECTION = EnumMoveDirection.NEUTRAL;
    }

        // シーン中にフレーム毎に呼ばれるメソッド
        void Update()
    {

        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // Do anything

            timeElapsed = 0.0f;
            // xの正方向にscrollスピードで移動
            ENUM_DIRECTION = enemyMoveingDirectionGetter.Get();
        }


        rb2d.velocity = new Vector2(0, 0);
        if (yakitoriFlag) {
            tempA = 99;
        }
        // スペースキーが押されたら
        else if (ENUM_DIRECTION.Equals(EnumMoveDirection.LEFT))
        {
            rb2d.velocity = new Vector2(-speed, 0);
            tempA = 3;
        }
        else if (ENUM_DIRECTION.Equals(EnumMoveDirection.RIGHT))
        {
            rb2d.velocity = new Vector2(speed, 0);
            tempA = 4;
        }
        else if (ENUM_DIRECTION.Equals(EnumMoveDirection.UP))
        {
            rb2d.velocity = new Vector2(0, speed);
            tempA = 1;
        }
        else if (ENUM_DIRECTION.Equals(EnumMoveDirection.DOWN))
        {
            rb2d.velocity = new Vector2(0, -speed);
            tempA = 2;
        }
        else
        {
            tempA = 0;
        }

        if (a != tempA)
        {
            a = tempA;
            Anim.SetInteger("a", a);

        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire")
        {
            yakitoriFlag = true;
            //Destroy(this.gameObject);
        }

        //Destroy(other.gameObject);
    }
}
