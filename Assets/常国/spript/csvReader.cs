using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI オブジェクトを扱う時は必須
using System.IO;　//追加
using System.Linq;
using System;
using UnityEngine.SceneManagement; // 忘れない！！

public class csvReader : MonoBehaviour
{
    private TextAsset csvFile; // CSVファイル
    private List<string[]> csvData = new List<string[]>(); // CSVファイルの中身を入れるリスト

    public string s3label;
    public int rnd;


    //int Qstart = 1;
    //int Qend = 21;
    //int Qransu;
    //int Qcount = 1;//問題出す回数

    List<int> Qnumbers = new List<int>();

    int[] Anser = new int[4] { 1, 2, 3, 4 };

    void Start()
    {
        rnd = UnityEngine.Random.Range(1, 101);

        //クエスチョンの乱数(決めた回数だけ出す)
        //for (int i = Qstart; i <= Qend; i++)
        //{
        //    Qnumbers.Add(i);
        //}
        //while (Qcount-- > 0)
        //{
        //    int index2 = Random.Range(0, Qnumbers.Count);
        //    Qransu = Qnumbers[index2];
        //    Qnumbers.RemoveAt(index2);
        //}

       

        Randam();
    }

    public static csvReader instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Title");
    }

    public void Randam()
    {
        //ランダム1～20
        

        csvFile = Resources.Load("question") as TextAsset; // ResourcesにあるCSVファイルを格納
        StringReader reader = new StringReader(csvFile.text); // TextAssetをStringReaderに変換

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1行ずつ読み込む
            csvData.Add(line.Split(',')); // csvDataリストに追加する

        }


        //データの表示
        //Debug.Log(csvData[i][0]);
        //  Debug.Log(csvData[i][1]);
        // Debug.Log(csvData[i][2]);
        // Debug.Log(csvData[i][3]);
        // Debug.Log(csvData[i][4]);

        //回答欄のシャッフル
        System.Random random = new System.Random();
        Anser = Anser.OrderBy(x => random.Next()).ToArray();

        //特定の名前のオブジェクトを検索してアクセス
        Text qLabel  = GameObject.Find("question").GetComponentInChildren<Text>();
        Text s1Label = GameObject.Find("select1").GetComponentInChildren<Text>();
        Text s2Label = GameObject.Find("select2").GetComponentInChildren<Text>();
        Text s3Label = GameObject.Find("select3").GetComponentInChildren<Text>();
        Text s4Label = GameObject.Find("select4").GetComponentInChildren<Text>();


        s1Label.text = csvData[rnd/*Qransu*/][1];
        s2Label.text = csvData[rnd/*Qransu*/][2];
        s3Label.text = csvData[rnd/*Qransu*/][3];
        s4Label.text = csvData[rnd/*Qransu*/][4];

        //データをセットすることで、既存情報を上書きできる

        s3label = s3Label.text;
        Debug.Log(s3label);

        //System.Random random = new System.Random();
        //Anser = Anser.OrderBy(x => random.Next()).ToArray();

        qLabel.text = csvData[rnd/*Qransu*/][0];//rndでランダムに1～20問出題

        s1Label.text = csvData[rnd/*Qransu*/][Anser[0]];
        s2Label.text = csvData[rnd/*Qransu*/][Anser[1]];
        s3Label.text = csvData[rnd/*Qransu*/][Anser[2]];
        s4Label.text = csvData[rnd/*Qransu*/][Anser[3]];

       // Debug.Log(s3label);
    }
}