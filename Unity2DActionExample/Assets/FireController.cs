using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour {


    // 変数の定義と初期化
    public float flap = 550f;
    public float scroll = 0.01f;
    Rigidbody2D rb2d;
    private Animator Anim;
    private int tempA;
    private int a;
    private float speed;
    public float timeOut;
    private float timeElapsed;
    EnumMoveDirection ENUM_DIRECTION;

    // Updateの前に1回だけ呼ばれるメソッド
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        speed = 0.5f;
    }

    // シーン中にフレーム毎に呼ばれるメソッド
    void Update()
    {

        rb2d.velocity = new Vector2(0, speed);
    }


}
