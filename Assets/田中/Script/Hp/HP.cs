using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class HP: MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 20;
    int currentHp;
    int damage = 1;

    //Sliderを入れる
    public Slider slider;

    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 1;


        //現在のHPを最大HPと同じに。
        currentHp = maxHp;


        //Debug.Log("Start currentHp : " + currentHp);
    }

    void Update()
    {

           

        // スペースキーが押されたかどうかを検出
        if (Input.GetKeyDown(KeyCode.Space))
        {

            currentHp = currentHp - damage;
            //現在のHPからダメージを引く
            slider.value = currentHp / (float)maxHp;


            // currentHpの保存
            PlayerPrefs.SetInt("currentHp", currentHp);



            // currentHpの読み込みする時にこのコードを描く
            //int currentHp = PlayerPrefs.GetInt("currentHp", 0);

        }

        if(currentHp <= 0)
        {
            Destroy(gameObject);

            //シーン名をここに入力
            SceneManager.LoadScene("clear");

        }


    }

}







//public class HP : MonoBehaviour
//{
//    public Slider hpGauge;   //残りHPゲージ
//    public TextMeshProUGUI hpText;  //残りHPを表示するテキスト
//    float hpEnemy; // 敵HP

//    void Start()
//    {
//        hpGauge.value = 1f; // HPゲージの初期値を設定
//        hpEnemy = 30f; // 初期の敵HPを設定
//        enemyPoint(); // HPテキストを更新
//    }

//    void Update()
//    {
//        // スペースキーが押されたかどうかを検出
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            float attack = Random.Range(0f, 10f); // 0から10までの攻撃
//            hpEnemy -= attack;      // 敵のHPをランダムで減少させる
//            Debug.Log("攻撃力:" + attack);
//            Debug.Log("敵HP" + hpEnemy);
//            hpGauge.value = hpEnemy / 30f;  // ゲージの値を更新
//            hpEnemy = Mathf.Max(hpEnemy, 0f); // HPが0未満にならないように調整
//            enemyPoint();   // HPテキストを更新
//        }
//    }
//    void enemyPoint()
//    {
//        hpText.text = hpEnemy.ToString("F1");   // 敵HPをテキストとして表示
//    }

//}