using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public int Q_count = 0;
    public static bool cnt2 = false;
    //public static int
    private void Awake()
    {
        //何問目か取得する
        Q_count = PlayerPrefs.GetInt("count", 0);
    }

    public void change_button()
    {
        Invoke("SceneChange", 0.5f);
    }

    public void TitleSceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Title");
    }
    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage1");
        cnt2 = true;

    }
}
