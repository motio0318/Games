using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！
using UnityEngine.UI;//UI オブジェクトを扱う時は必須
using System.IO;　//追加

public class judgementButton : MonoBehaviour
{
    private TextAsset csvFile; // CSVファイル
    private List<string[]> csvData = new List<string[]>(); // CSVファイルの中身を入れるリスト


    [SerializeField, Header("決定音")]
    private GameObject submitSE;

    private void Start()
    {
        csvFile = Resources.Load("question") as TextAsset; // ResourcesにあるCSVファイルを格納
        StringReader reader = new StringReader(csvFile.text); // TextAssetをStringReaderに変換

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1行ずつ読み込む
            csvData.Add(line.Split(',')); // csvDataリストに追加する

        }

        Instantiate(submitSE);
    }

    public void OnClick()
    {

        /*if(//もしselect3だったら)
         {
             Invoke("SceneChange", 0.5f);
         }
        */
        /*else if (//もしselect1だったら,もしselect2だったら,もしselect4だったら)
        {
            Invoke("SceneChange2", 0.5f);
        }*/
    }

    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3 qestion");//正解へ
    }

    public void SceneChange2()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3 qestion");//不正解へ
    }
}
