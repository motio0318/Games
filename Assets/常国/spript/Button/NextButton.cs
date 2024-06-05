using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class NextButton : PHP
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



        if (PHP.P_Hp == 2)
        {
            changeScene.cnt2 = false;
            this.obj1.SetActive(false);


        }

        if (PHP.P_Hp == 1)
        {

            //HP３を減らす

            changeScene.cnt2 = false;
            this.obj1.SetActive(false);
            this.obj2.SetActive(false);


        }
        Invoke("SceneChange", 0.5f);
        ////3問目ならタイトルへ(仮)
        //if (Q_count == 3)
        //{
        //    TitleSceneChange();
        //}
        //else
        //{
        //    Invoke("SceneChange", 0.5f);
        //}

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


