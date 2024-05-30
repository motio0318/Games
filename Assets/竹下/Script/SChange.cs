using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class SChange : MonoBehaviour
{
    public void Title()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Title");
    }

    public void Describe()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Describe");
    }

    public void Explanation2()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Explanation2");
    }

}
