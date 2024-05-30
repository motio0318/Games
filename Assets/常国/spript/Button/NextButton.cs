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

        Invoke("SceneChange", 0.5f);

    }

    //public void TitleSceneChange()
    //{
    //    SceneManager.LoadScene("Title");
    //}

    public void SceneChange()
    {
        cnt = true;
        //敵シーンへ
        SceneManager.LoadScene("Stage1");
    }

}


