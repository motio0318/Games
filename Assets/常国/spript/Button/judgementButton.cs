using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I
using UnityEngine.UI;//UI �I�u�W�F�N�g���������͕K�{
using System.IO;�@//�ǉ�

public class judgementButton : MonoBehaviour
{
    private TextAsset csvFile; // CSV�t�@�C��
    private List<string[]> csvData = new List<string[]>(); // CSV�t�@�C���̒��g�����郊�X�g


    [SerializeField, Header("���艹")]
    private GameObject submitSE;

    private void Start()
    {
        csvFile = Resources.Load("question") as TextAsset; // Resources�ɂ���CSV�t�@�C�����i�[
        StringReader reader = new StringReader(csvFile.text); // TextAsset��StringReader�ɕϊ�

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine(); // 1�s���ǂݍ���
            csvData.Add(line.Split(',')); // csvData���X�g�ɒǉ�����

        }

        Instantiate(submitSE);
    }

    public void OnClick()
    {

        /*if(//����select3��������)
         {
             Invoke("SceneChange", 0.5f);
         }
        */
        /*else if (//����select1��������,����select2��������,����select4��������)
        {
            Invoke("SceneChange2", 0.5f);
        }*/
    }

    public void SceneChange()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage3 qestion");//������
    }

    public void SceneChange2()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage3 qestion");//�s������
    }
}
