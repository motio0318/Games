using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class SceneChange : MonoBehaviour
{
    [SerializeField, Header("決定音")]
    private GameObject submitSE;

    public void stage01()
    {
        Instantiate(submitSE);

        Invoke("SceneChange1", 0.5f);
    }
    public void SceneChange1()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage1");
    }

    public void stage02()
    {
        Instantiate(submitSE);

        Invoke("SceneChange2", 0.5f);

    }
    public void SceneChange2()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage2");
    }

    public void stage03()
    {
        Instantiate(submitSE);

        Invoke("SceneChange3", 0.5f);

    }
    public void SceneChange3()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3");
    }

    public void Return()
    {
        Instantiate(submitSE);

        Invoke("SceneChangeReturn", 0.5f);

    }
    public void SceneChangeReturn()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Title");
    }
}