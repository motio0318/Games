using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class QuestionNext : MonoBehaviour
{
    [SerializeField, Header("出題音")]
    private GameObject submitSE;

    private void Start()
    {
        Instantiate(submitSE);

        Invoke("SceneChange", 5.0f);
    }

    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3 qestion");
    }

}

