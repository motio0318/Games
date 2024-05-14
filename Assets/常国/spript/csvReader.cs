using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI オブジェクトを扱う時は必須
using System.IO;　//追加

public class csvReader : MonoBehaviour
{
    private TextAsset csvFile; // CSVファイル
    private List<string[]> csvData = new List<string[]>(); // CSVファイルの中身を入れるリスト

    void Start()
    {
        //ランダム1～20
        int rnd = Random.Range(1, 21);
        int rnd2 = Random.Range(1, 5);

        csvFile = Resources.Load("question") as TextAsset; // ResourcesにあるCSVファイルを格納
        StringReader reader = new StringReader(csvFile.text); // TextAssetをStringReaderに変換

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1行ずつ読み込む
            csvData.Add(line.Split(',')); // csvDataリストに追加する

        }

        for (int i = 0; i < csvData.Count; i++) // csvDataリストの条件を満たす値の数（全て）
        {
            // データの表示
            Debug.Log(csvData[i][0]);
            Debug.Log(csvData[i][1]);
            Debug.Log(csvData[i][2]);
            Debug.Log(csvData[i][3]);
            Debug.Log(csvData[i][4]);

            //特定の名前のオブジェクトを検索してアクセス
            Text qLabel = GameObject.Find("question").GetComponentInChildren<Text>();
            Text s1Label = GameObject.Find("select1").GetComponentInChildren<Text>();
            Text s2Label = GameObject.Find("select2").GetComponentInChildren<Text>();
            Text s3Label = GameObject.Find("select3").GetComponentInChildren<Text>();
            Text s4Label = GameObject.Find("select4").GetComponentInChildren<Text>();
            //データをセットすることで、既存情報を上書きできる

            qLabel.text = csvData[rnd][0];//rndでランダムに1～20問出題

            s1Label.text = csvData[rnd][1];
            s2Label.text = csvData[rnd][2];
            s3Label.text = csvData[rnd][3];
            s4Label.text = csvData[rnd][4];
        }
    }
}