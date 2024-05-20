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

    public void BackToMenu()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
    }
}
