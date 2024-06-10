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
    public int R_cnt = 0;
    public int list_onedake = 0;
    public int List_count = 0;

    public List<int> numbers = new List<int>();

    //�𓚗��̃V���b�t���p
    int[] Anser = new int[4] { 1, 2, 3, 4 };

    public int ransu = 0;


   

    void Start()
    {
        PlayerPrefs.GetInt("list_onedake",0);//�擾
        PlayerPrefs.GetInt("numbers", 0);//�擾
        PlayerPrefs.GetInt("List_count", 0);//�擾

       //List�V���b�t���͂ł��Ă���
       //List�̕ۑ��ƌĂяo�����ł��Ă��邩���킩��Ȃ�
       //���͏d������



        //���񂾂�
        if (list_onedake == 0)
        {
            //���X�g�ɂP�O�O���Ԃɓ����
            for (int k = 1; k <= 101; k++)
            {
                numbers.Add(k);
            }
            //���������Ȃ��悤�ɐ��l��ύX
            list_onedake += 1;

            PlayerPrefs.SetInt("list_onedake", list_onedake);//�ۑ�

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
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Title");
    }

    void Shuffle()
    {
        //�V���b�t�����Ă�
        numbers = numbers.OrderBy(a => Guid.NewGuid()).ToList();
       
        for(int g = 0; g <= 100; g++)
        {
            PlayerPrefs.SetInt("numbers", numbers[g]);//�ۑ�
        }
    }

    public void QRandam()
    {
        

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


        s1Label.text = csvData[numbers[List_count]/*Qransu*/][1];
        s2Label.text = csvData[numbers[List_count]/*Qransu*/][2];
        s3Label.text = csvData[numbers[List_count]/*Qransu*/][3];
        s4Label.text = csvData[numbers[List_count]/*Qransu*/][4];

        //�f�[�^���Z�b�g���邱�ƂŁA���������㏑���ł���

        s3label = s3Label.text;
        //Debug.Log(s3label);

        qLabel.text = csvData[numbers[List_count]/*Qransu*/][0];//rnd�Ń����_����1�`20��o��

        s1Label.text = csvData[numbers[List_count]/*Qransu*/][Anser[0]];
        s2Label.text = csvData[numbers[List_count]/*Qransu*/][Anser[1]];
        s3Label.text = csvData[numbers[List_count]/*Qransu*/][Anser[2]];
        s4Label.text = csvData[numbers[List_count]/*Qransu*/][Anser[3]];

        List_count += 1;
        PlayerPrefs.SetInt("List_count", List_count);//�ۑ�


                                                     // Debug.Log(s3label);
    }
}