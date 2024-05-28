using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI �I�u�W�F�N�g���������͕K�{
using System.IO;�@//�ǉ�
using System.Linq;
using System;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class csvReader : MonoBehaviour
{
    private TextAsset csvFile; // CSV�t�@�C��
    private List<string[]> csvData = new List<string[]>(); // CSV�t�@�C���̒��g�����郊�X�g

    public string s3label;
    public int rnd;


    //int Qstart = 1;
    //int Qend = 21;
    //int Qransu;
    //int Qcount = 1;//���o����

    List<int> Qnumbers = new List<int>();

    int[] Anser = new int[4] { 1, 2, 3, 4 };

    void Start()
    {
        rnd = UnityEngine.Random.Range(1, 101);

        //�N�G�X�`�����̗���(���߂��񐔂����o��)
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
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Title");
    }

    public void Randam()
    {
        //�����_��1�`20
        

        csvFile = Resources.Load("question") as TextAsset; // Resources�ɂ���CSV�t�@�C�����i�[
        StringReader reader = new StringReader(csvFile.text); // TextAsset��StringReader�ɕϊ�

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1�s���ǂݍ���
            csvData.Add(line.Split(',')); // csvData���X�g�ɒǉ�����

        }


        //�f�[�^�̕\��
        //Debug.Log(csvData[i][0]);
        //  Debug.Log(csvData[i][1]);
        // Debug.Log(csvData[i][2]);
        // Debug.Log(csvData[i][3]);
        // Debug.Log(csvData[i][4]);

        //�񓚗��̃V���b�t��
        System.Random random = new System.Random();
        Anser = Anser.OrderBy(x => random.Next()).ToArray();

        //����̖��O�̃I�u�W�F�N�g���������ăA�N�Z�X
        Text qLabel  = GameObject.Find("question").GetComponentInChildren<Text>();
        Text s1Label = GameObject.Find("select1").GetComponentInChildren<Text>();
        Text s2Label = GameObject.Find("select2").GetComponentInChildren<Text>();
        Text s3Label = GameObject.Find("select3").GetComponentInChildren<Text>();
        Text s4Label = GameObject.Find("select4").GetComponentInChildren<Text>();


        s1Label.text = csvData[rnd/*Qransu*/][1];
        s2Label.text = csvData[rnd/*Qransu*/][2];
        s3Label.text = csvData[rnd/*Qransu*/][3];
        s4Label.text = csvData[rnd/*Qransu*/][4];

        //�f�[�^���Z�b�g���邱�ƂŁA���������㏑���ł���

        s3label = s3Label.text;
        Debug.Log(s3label);

        //System.Random random = new System.Random();
        //Anser = Anser.OrderBy(x => random.Next()).ToArray();

        qLabel.text = csvData[rnd/*Qransu*/][0];//rnd�Ń����_����1�`20��o��

        s1Label.text = csvData[rnd/*Qransu*/][Anser[0]];
        s2Label.text = csvData[rnd/*Qransu*/][Anser[1]];
        s3Label.text = csvData[rnd/*Qransu*/][Anser[2]];
        s4Label.text = csvData[rnd/*Qransu*/][Anser[3]];

       // Debug.Log(s3label);
    }
}