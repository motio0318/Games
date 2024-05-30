using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン切り替えするときは忘れない！！

public class ClearButton : MonoBehaviour
{
    [SerializeField, Header("決定音")]
    private GameObject submitSE;

    //ボタンが押されたら
    public void OnClick()
    {
        //SE鳴らす
        Instantiate(submitSE);

        //10秒後に呼び出し
        Invoke("SceneChange", 10);
    }

    public void SceneChange()
    {
        //タイトルシーンへ
        SceneManager.LoadScene("Title");
    }
}

