using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class NextButton : MonoBehaviour
{
    [SerializeField, Header("決定音")]
    private GameObject submitSE;

    public static bool cnt = false;

    public void OnClick()
    {
        Instantiate(submitSE);

        Invoke("SceneChange", 0.5f);
    }

    public void SceneChange()
    {

        cnt = true;
        //シーン名をここに入力
        SceneManager.LoadScene("Stage1");
    }

}


