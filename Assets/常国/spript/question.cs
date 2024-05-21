using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class question : MonoBehaviour
{
    TextAsset csvFile; // CSV�t�@�C��
    public static List<string[]> csvDatas = new List<string[]>(); // CSV�̒��g�����郊�X�g;  
    public static List<int> qnumber = new List<int>(); // �o��ԍ����X�g;     
    public int csvrow; // CSV�t�@�C���̍s��
    public static string answer; // �N�C�Y�̓���   
    private int k = 0; //�z��̕ϐ�
    private int qransu = 0; // �o�肷����̍s      

    void Start()
    {
        int qcount = 0; //= gamestart.getqCount();
        if (qcount == 0) // �P��ڂ݈̂ȉ��������s��
        {
            csvFile = Resources.Load("questiondata") as TextAsset; // Resouces����CSV�ǂݍ���
            StringReader reader = new StringReader(csvFile.text);
            while (reader.Peek() != -1) // reader.Peaek��-1�ɂȂ�܂�
            {
                string line = reader.ReadLine(); // ��s���ǂݍ���
                csvDatas.Add(line.Split(',')); // , ��؂�Ń��X�g�ɒǉ�
                csvrow++; // CSV�t�@�C���̍s���J�E���g
            }
            for (int j = 1; j <= csvrow - 1; j++)
            {
                qnumber.Add(j); // CSV�t�@�C���̍s�����X�g�ɒǉ��i1�s�ڂ͏��O�j
            }
            qnumber = qnumber.OrderBy(a => System.Guid.NewGuid()).ToList(); // �ǂݍ��񂾃��X�g���V���b�t�� 
            csvrow = 0; //�ϐ�������
        }
        qransu = qnumber[qcount]; // �V���b�t�����ꂽ���X�g���萔���Ɏ擾
        QuestionLabelSet();
        AnswerLabelSet();
    }

    private void QuestionLabelSet()
    {
        csvDatas[k] = csvDatas[qransu]; // CSV��"qransu"�s�ڂ̖����擾      
        Text qLabel = GameObject.Find("Canvas/Question").GetComponent<Text>();
        qLabel.text = csvDatas[k][0];
    }

    private void AnswerLabelSet()
    {
        //�񓚕��ʂ̍쐬
        string[] array = new string[] { csvDatas[k][2], csvDatas[k][3], csvDatas[k][4], csvDatas[k][5] };
        array = array.OrderBy(x => System.Guid.NewGuid()).ToArray(); // �񓚌��̃��X�g���V���b�t��
        //�{�^����4����̂ł��ꂼ����
        for (int i = 1; i <= 4; i++)
        {
            Text aLabel = GameObject.Find("Canvas/Button" + i).GetComponentInChildren<Text>();
            aLabel.text = array[i - 1];
            answer = csvDatas[k][1];
        }
    }
}