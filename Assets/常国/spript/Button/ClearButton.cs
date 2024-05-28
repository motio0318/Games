using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class ClearButton : MonoBehaviour
{
    [SerializeField, Header("決定音")]
    private GameObject submitSE;

    public int Count = 0;

    void Start()
    {

        OnClick();
    }
    public void OnClick()
    {
        Instantiate(submitSE);

        Invoke("SceneChange", 0.5f);
    }

    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Title");
    }

}

