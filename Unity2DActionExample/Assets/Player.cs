using UnityEngine;
using System.Collections;
using Assets;

public class Player : MonoBehaviour
{

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

        rb2d.velocity = new Vector2(0, 0);

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


        rb2d.velocity = new Vector2(Mathf.Clamp(moveValue, screenLeftPoint.transform.position.x, screenRightPoint.transform.position.x), 0);

        if (a != tempA)
        {
            a = tempA;
            Anim.SetInteger("a", a);

        }

    }
}
