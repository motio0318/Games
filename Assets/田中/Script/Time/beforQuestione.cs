using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 忘れない！！


public class beforQuestione : MonoBehaviour
{
    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("LoadBar").GetComponent<Slider>();
    }

    float _hp = 0;
    void Update()
    {
        // HP上昇
        _hp += 0.01f;
        if (_hp > 16)
        {
            // 最大を超えたら0に戻す
            //_hp = 0;


            //シーン名をここに入力
            SceneManager.LoadScene("Stage3 interval");

        }

        // HPゲージに値を設定
        _slider.value = _hp;
    }
}
