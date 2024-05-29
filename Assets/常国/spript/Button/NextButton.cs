using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class NextButton : MonoBehaviour
{
    [SerializeField, Header("決定音")]
    private GameObject submitSE;

    public static bool cnt = false;

    public int Q_count = 0;

    private void Awake()
    {
        //何問目か取得する
        Q_count = PlayerPrefs.GetInt("count", 0);
    }

    public void OnClick()
    {
        Instantiate(submitSE);

        //3問目ならタイトルへ(仮)
        if(Q_count == 3)
        {
            TitleSceneChange();
        }
        else
        {
            Invoke("SceneChange", 0.5f);
        }
       
    }

    public void TitleSceneChange()
    {
        SceneManager.LoadScene("Title");
    }

    public void SceneChange()
    {

        cnt = true;
        //シーン名をここに入力
        SceneManager.LoadScene("Stage1");
    }

}


