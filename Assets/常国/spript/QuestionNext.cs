using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class QuestionNext : MonoBehaviour
{
    private void Start()
    {

        Invoke("SceneChange", 5.0f);
    }

    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3 qestion");
    }

}

