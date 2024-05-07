using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HP : MonoBehaviour
{
    public Slider hpGauge;   //残りHPゲージ
    public TextMeshProUGUI hpText;  //残りHPを表示するテキスト
    float hpEnemy; // 敵HP

    void Start()
    {
        hpGauge.value = 1f; // HPゲージの初期値を設定
        hpEnemy = 30f; // 初期の敵HPを設定
        enemyPoint(); // HPテキストを更新
    }

    void Update()
    {
        // スペースキーが押されたかどうかを検出
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float attack = Random.Range(0f, 10f); // 0から10までの攻撃
            hpEnemy -= attack;      // 敵のHPをランダムで減少させる
            Debug.Log("攻撃力:" + attack);
            Debug.Log("敵HP" + hpEnemy);
            hpGauge.value = hpEnemy / 30f;  // ゲージの値を更新
            hpEnemy = Mathf.Max(hpEnemy, 0f); // HPが0未満にならないように調整
            enemyPoint();   // HPテキストを更新
        }
    }

    void enemyPoint()
    {
        hpText.text = hpEnemy.ToString("F1");   // 敵HPをテキストとして表示
    }
}