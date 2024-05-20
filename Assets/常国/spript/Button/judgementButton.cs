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

    //int rnd2 = Random.Range(1, 5);

    csvReader csvreader;
    public GameObject question;

    private void Start()
    {
        Instantiate(submitSE);

        csvreader = question.GetComponent<csvReader>();
       
        //csvReader.instance.Randam();
    }

    public void Push_Button()//CSVから４つのボタンのそれぞれの引数を取得する
    {
        //csvreader = question.GetComponent<csvReader>();
        Text a = GetComponentInChildren<Text>();
        //Debug.Log(a.text);
        //Debug.Log(csvreader.s3label);
        if ( a.text == csvreader.s3label) 
        {
            //Invoke("SceneChange", 0.5f);
            SceneChange();
        }
        else
        {
            SceneChange2();
        }
        //if (rnd2 == 3)//もしselect3だったら
        //{
        //    Invoke("SceneChange", 0.5f);
        //}

        //else if (rnd2 != 3)//もしselect1だったら,もしselect2だったら,もしselect4だったら)
        //{
        //    Invoke("SceneChange2", 0.5f);
        //}
    }

    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3 right");//正解へ
    }

    public void SceneChange2()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3 qestion");//不正解へ
    }
}
