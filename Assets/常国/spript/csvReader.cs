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
    public int R_cnt = 0;
    public int list_onedake = 0;
    public int List_count = 0;

    public List<int> numbers = new List<int>();

    //解答欄のシャッフル用
    int[] Anser = new int[4] { 1, 2, 3, 4 };

    public int ransu = 0;


   

    void Start()
    {
        PlayerPrefs.GetInt("list_onedake",0);//取得
        PlayerPrefs.GetInt("numbers", 0);//取得
        PlayerPrefs.GetInt("List_count", 0);//取得

       //Listシャッフルはできている
       //Listの保存と呼び出しができているかがわからない
       //今は重複する



        //初回だけ
        if (list_onedake == 0)
        {
            //リストに１００個順番に入れる
            for (int k = 1; k <= 101; k++)
            {
                numbers.Add(k);
            }
            //もう動かないように数値を変更
            list_onedake += 1;

            PlayerPrefs.SetInt("list_onedake", list_onedake);//保存

            Shuffle();
        }
       
        QRandam();
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

    void Shuffle()
    {
        //シャッフルしてる
        numbers = numbers.OrderBy(a => Guid.NewGuid()).ToList();
       
        for(int g = 0; g <= 100; g++)
        {
            PlayerPrefs.SetInt("numbers", numbers[g]);//保存
        }
    }

    public void QRandam()
    {
        

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


        s1Label.text = csvData[numbers[List_count]/*Qransu*/][1];
        s2Label.text = csvData[numbers[List_count]/*Qransu*/][2];
        s3Label.text = csvData[numbers[List_count]/*Qransu*/][3];
        s4Label.text = csvData[numbers[List_count]/*Qransu*/][4];

        //データをセットすることで、既存情報を上書きできる

        s3label = s3Label.text;
        //Debug.Log(s3label);

        qLabel.text = csvData[numbers[List_count]/*Qransu*/][0];//rndでランダムに1～20問出題

        s1Label.text = csvData[numbers[List_count]/*Qransu*/][Anser[0]];
        s2Label.text = csvData[numbers[List_count]/*Qransu*/][Anser[1]];
        s3Label.text = csvData[numbers[List_count]/*Qransu*/][Anser[2]];
        s4Label.text = csvData[numbers[List_count]/*Qransu*/][Anser[3]];

        List_count += 1;
        PlayerPrefs.SetInt("List_count", List_count);//保存


                                                     // Debug.Log(s3label);
    }
}