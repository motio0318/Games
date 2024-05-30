using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class HP: MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 10;
    public int currentHp;
    int damage = 1;

    //Sliderを入れる
    public Slider slider;

    public static HP i_HP;

    public void Awake()
    {
        if (i_HP == null)
        {
            i_HP = this;
        }
    }

    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 1;


        //現在のHPを最大HPと同じに。
        currentHp = maxHp;

        //保存されている敵のHPを取得
        currentHp = PlayerPrefs.GetInt("currentHp",0);

        HP_herasu();
    }

    void HP_herasu()
    {
        //NextButtonを取得
        NextButton nextButton = GetComponent<NextButton>();
           

        // NextButttonが押されたかどうかを検出
        if (NextButton.cnt == true)
        {
            //現在のHPからダメージを引く
            currentHp = currentHp - damage;
            slider.value = currentHp / (float)maxHp;
            NextButton.cnt = false;

            //敵のHPを保存
            PlayerPrefs.SetInt("currentHp",currentHp);

        }

        //もし敵のHPが0になったら
        if(currentHp <= 0)
        {
            //敵とHPを消す
            Destroy(gameObject);

            //7秒後に呼び出し
            Invoke("ChangeScene_clear", 7);
            Debug.Log(currentHp);
        }
        //5秒後に呼び出し
        Invoke("ChangeScene_Interval", 5);


    }
    void ChangeScene_Interval()
    {
        //第何問シーンへ
        SceneManager.LoadScene("Stage3 interval");
    }

    void ChangeScene_clear()
    {
        //クリアシーンへ
        SceneManager.LoadScene("clear");
    }
}