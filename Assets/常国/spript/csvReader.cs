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

            //����̖��O�̃I�u�W�F�N�g���������ăA�N�Z�X
            Text qLabel = GameObject.Find("question").GetComponentInChildren<Text>();
            //�f�[�^���Z�b�g���邱�ƂŁA���������㏑���ł���
            qLabel.text = csvData[i][0];
            //�Ƃ肠���������o�������ǂ����Ƀ����_���v�f��ǉ�����
        }
    }
}