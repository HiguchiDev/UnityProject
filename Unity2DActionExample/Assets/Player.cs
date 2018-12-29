using UnityEngine;
using System.Collections;
using Assets;

public class Player : MonoBehaviour
{
    private int attackInterval;
    private int attackIntervalCount;
    // 変数の定義と初期化
    public float flap = 550f;
    public float scroll = 0.01f;
    Rigidbody2D rb2d;
    private Animator Anim;
    private int tempA;
    private int a;
    private const float MOVE_SPEED = 1.5f;
    PlayerMovingDirectionGetter playerMoveingDirectionGetter;
    private GameObject screenLeftPoint;
    private GameObject screenRightPoint;

    // Updateの前に1回だけ呼ばれるメソッド
    void Start()
    {
        attackIntervalCount = 0;
        attackInterval = 15;
        tempA = 0;
        a = 0;
        Anim = GetComponent<Animator>();
        // Rigidbody2Dをキャッシュする
        rb2d = GetComponent<Rigidbody2D>();

        playerMoveingDirectionGetter = new PlayerMovingDirectionGetter();

        screenLeftPoint = GameObject.Find("ScreeanLeftPoint");
        screenRightPoint = GameObject.Find("ScreeanRightPoint");
    }

    // シーン中にフレーム毎に呼ばれるメソッド
    void Update()
    {

        // xの正方向にscrollスピードで移動
        EnumMoveDirection ENUM_DIRECTION = playerMoveingDirectionGetter.Get();

        Vector2 velocity = new Vector2(0, 0);

        float moveValue = 0;

        // スペースキーが押されたら
        if (ENUM_DIRECTION.Equals(EnumMoveDirection.LEFT))
        {

            moveValue = -MOVE_SPEED;
            tempA = 3;
        }
        else if (ENUM_DIRECTION.Equals(EnumMoveDirection.RIGHT))
        {
            moveValue = MOVE_SPEED;
            tempA = 4;
        }
        else
        {
            //   rb2d.velocity = new Vector2(0, speed);
            tempA = 1;
        }

                                        //-1.6
        if(transform.position.x > screenLeftPoint.transform.position.x &&
           moveValue < 0){
            velocity.x = moveValue;
        }
                                        //1.6
        else if(transform.position.x < screenRightPoint.transform.position.x &&
           moveValue > 0){
            velocity.x = moveValue;
        }

        rb2d.velocity = velocity;
        /*rb2d.velocity = new Vector2(//x
                                    Mathf.Clamp(moveValue,
                                                screenLeftPoint.transform.position.x, 
                                                screenRightPoint.transform.position.x),
                                    //y
                                    0);*/

        if (a != tempA)
        {
            a = tempA;
            Anim.SetInteger("a", a);

        }

        if (attackIntervalCount < attackInterval) {
            attackIntervalCount++;
        }

        // スペースキーが押されたら
        if (attackIntervalCount == attackInterval && Input.GetKey(KeyCode.Space))
        {
            print("shoot");
            attackIntervalCount = 0;
            GameObject prefabs;
            prefabs = (GameObject)Resources.Load("BulletPrefab");
            GameObject shell = (GameObject)Instantiate(prefabs,
                                                       new Vector3(this.transform.position.x,
                                                                   this.transform.position.y,
                                                                   1), Quaternion.identity);
        }

    }
}
