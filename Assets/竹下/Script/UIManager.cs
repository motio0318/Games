using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //2つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject MainPanel1;
    [SerializeField] GameObject MainPanel2;

    [SerializeField] GameObject Panel1;
    [SerializeField] GameObject Panel2;
    [SerializeField] GameObject Panel3;
    [SerializeField] GameObject Panel4;
    [SerializeField] GameObject Panel5;

    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        BackToMenu();
    }

    public void Main1()
    {
        MainPanel1.SetActive(true);
        MainPanel2.SetActive(false);
    }

    public void Main2()
    {
        MainPanel2.SetActive(true);
        MainPanel1.SetActive(false);

    }

    public void Quiz()
    {
        Panel1.SetActive(true);
    }

    public void Answer()
    {
        Panel2.SetActive(true);
    }

    public void Heart()
    {
        Panel3.SetActive(true);
    }

    public void Timer()
    {
        Panel4.SetActive(true);
    }

    public void enemy()
    {
        Panel5.SetActive(true);
    }




    public void BackToMenu()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        Panel5.SetActive(false);
    }
}
