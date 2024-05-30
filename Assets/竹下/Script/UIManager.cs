using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //2つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject Panel1;
    [SerializeField] GameObject Panel2;
    [SerializeField] GameObject Panel3;
    [SerializeField] GameObject Panel4;

    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        BackToMenu();
    }

    public void SelectXrHubDescription()
    {
        Panel1.SetActive(true);
    }

    public void SelectUnityDescriptio()
    {
        Panel2.SetActive(true);
    }

    public void Heart()
    {
        Panel3.SetActive(true);
    }

    public void Timer()
    {
        Panel3.SetActive(true);
    }



    public void BackToMenu()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
    }
}
