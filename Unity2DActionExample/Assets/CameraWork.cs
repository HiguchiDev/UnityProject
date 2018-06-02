using UnityEngine;
using System.Collections;

public class CameraWork : MonoBehaviour
{

    // 変数の定義
    private Transform target;

    private int screenHeight;

    // シーン開始時に一度だけ呼ばれる関数
    void Start()
    {
        screenHeight = Screen.height;

        // 変数にPlayerオブジェクトのtransformコンポーネントを代入
        target = GameObject.Find("Fire2 (1)").transform;

    }

    // シーン中にフレーム毎に呼ばれる関数
    void Update()
    {
        // カメラのx座標をPlayerオブジェクトのx座標から取得y座標とz座標は現在の状態を維持
        transform.position = new Vector3(transform.position.x, target.position.y + 1.55f, transform.position.z);
    }
}