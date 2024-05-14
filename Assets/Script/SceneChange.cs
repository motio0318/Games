using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class SceneChange : MonoBehaviour
{
    public void LoadScene()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage1");
    }
}