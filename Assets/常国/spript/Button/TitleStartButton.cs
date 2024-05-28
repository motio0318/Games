using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class TitleStartButton : MonoBehaviour
{
    [SerializeField, Header("決定音")]
    private GameObject submitSE;

    private void Awake()
    {
        PlayerPrefs.SetInt("count", 0);//保存
    }

    public void OnClick()
    {
        Instantiate(submitSE);

       Invoke("SceneChange", 0.5f);
    }

    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Select");
    }

}