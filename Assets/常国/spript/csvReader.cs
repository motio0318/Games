using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI �I�u�W�F�N�g���������͕K�{
using System.IO;�@//�ǉ�

public class csvReader : MonoBehaviour
{
    private TextAsset csvFile; // CSV�t�@�C��
    private List<string[]> csvData = new List<string[]>(); // CSV�t�@�C���̒��g�����郊�X�g

    void Start()
    {
        //�����_��1�`20
        int rnd = Random.Range(1, 21);
        int rnd2 = Random.Range(1, 5);

        csvFile = Resources.Load("question") as TextAsset; // Resources�ɂ���CSV�t�@�C�����i�[
        StringReader reader = new StringReader(csvFile.text); // TextAsset��StringReader�ɕϊ�

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1�s���ǂݍ���
            csvData.Add(line.Split(',')); // csvData���X�g�ɒǉ�����

        }

        for (int i = 0; i < csvData.Count; i++) // csvData���X�g�̏����𖞂����l�̐��i�S�āj
        {
            // �f�[�^�̕\��
            Debug.Log(csvData[i][0]);
            Debug.Log(csvData[i][1]);
            Debug.Log(csvData[i][2]);
            Debug.Log(csvData[i][3]);
            Debug.Log(csvData[i][4]);

            //����̖��O�̃I�u�W�F�N�g���������ăA�N�Z�X
            Text qLabel = GameObject.Find("question").GetComponentInChildren<Text>();
            Text s1Label = GameObject.Find("select1").GetComponentInChildren<Text>();
            Text s2Label = GameObject.Find("select2").GetComponentInChildren<Text>();
            Text s3Label = GameObject.Find("select3").GetComponentInChildren<Text>();
            Text s4Label = GameObject.Find("select4").GetComponentInChildren<Text>();
            //�f�[�^���Z�b�g���邱�ƂŁA���������㏑���ł���

            qLabel.text = csvData[rnd][0];//rnd�Ń����_����1�`20��o��

            s1Label.text = csvData[rnd][1];
            s2Label.text = csvData[rnd][2];
            s3Label.text = csvData[rnd][3];
            s4Label.text = csvData[rnd][4];
        }
    }
}