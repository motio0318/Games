using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class SChange : MonoBehaviour
{
    public void Title()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Taitole");
    }

    public void Explanation1()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Explanation1");
    }

    public void Explanation2()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Explanation2");
    }

}
