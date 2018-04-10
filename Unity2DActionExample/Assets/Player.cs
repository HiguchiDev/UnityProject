using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    // 変数の定義と初期化
    public float flap = 550f;
    public float scroll = 0.01f;
    Rigidbody2D rb2d;
    private Animator Anim;
    private int tempA;
    private int a;
    private float speed;

    // Updateの前に1回だけ呼ばれるメソッド
    void Start()
    {
        tempA = 0;
        a = 0;
        Anim = GetComponent<Animator>();
        // Rigidbody2Dをキャッシュする
        rb2d = GetComponent<Rigidbody2D>();

        speed = 2.0f;
    }

    // シーン中にフレーム毎に呼ばれるメソッド
    void Update()
    {

        // xの正方向にscrollスピードで移動
       
        rb2d.velocity = new Vector2(0, 0);
        // スペースキーが押されたら
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.velocity = new Vector2(-speed, 0);
            tempA = 3;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.velocity = new Vector2(speed, 0);
            tempA = 4;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.velocity = new Vector2(0, speed);
            tempA = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2d.velocity = new Vector2(0, -speed);
            tempA = 2;
        }
        else
        {
            tempA = 0;
        }

        if(a != tempA)
        {
            a = tempA;
            Anim.SetInteger("a", a);

        }

    }
}
