using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // OnHitBulletメッセージから呼び出されることを想定
    void OnHitBullet()
    {
        // 自身のゲームオブジェクトを廃棄
        Destroy(gameObject);
    }

}
