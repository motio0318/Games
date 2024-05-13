using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class seane : MonoBehaviour
{
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "stage1")
        { // hogehogeシーンでのみやりたい処理

        }
        else
        { // それ以外のシーンでやりたい処理

        }
    }
    public void Taitle()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Title");

    }

    public void stage01()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("stage1");
    }
    public void stage02()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage2");
    }
}