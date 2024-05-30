using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 忘れない！！


public class beforQuestione : MonoBehaviour
{
    public static beforQuestione i_beforQuestione;

    public void Awake()
    {
        if (i_beforQuestione == null)
        {
            i_beforQuestione = this;
        }
    }

    public float Max = 10;
    Slider _slider;
    public int count = 0;

    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("LoadBar").GetComponent<Slider>();

        //保存されている何問目かを取得
        count = PlayerPrefs.GetInt("count", 0);

        //何問目かを1ずつ増やす
        count += 1;

        //何問目かを保存
        PlayerPrefs.SetInt("count", count);
    }

    float _hp = 0;
    void Update()
    {
        // HP上昇
        _hp += 0.01f;
        if (_hp > Max)
        {
            // 最大を超えたら0に戻す
            _hp = 0;


            //シーン名をここに入力
            SceneManager.LoadScene("Stage3 qestion");

          
        }
        // HPゲージに値を設定
        _slider.value = _hp;
    }
}
