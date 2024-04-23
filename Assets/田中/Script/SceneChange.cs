using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class SceneChange : MonoBehaviour
{
    public void stage01()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage1");
    }

    public void stage02()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage2");
    }
    public void stage03()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3");
    }
}