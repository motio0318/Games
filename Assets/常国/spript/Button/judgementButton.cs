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

    //int rnd2 = Random.Range(1, 5);

    csvReader csvreader;
    public GameObject question;

    private void Start()
    {
        Instantiate(submitSE);

        csvreader = question.GetComponent<csvReader>();
       
        //csvReader.instance.Randam();
    }

    public void Push_Button()//CSV����S�̃{�^���̂��ꂼ��̈������擾����
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
        //if (rnd2 == 3)//����select3��������
        //{
        //    Invoke("SceneChange", 0.5f);
        //}

        //else if (rnd2 != 3)//����select1��������,����select2��������,����select4��������)
        //{
        //    Invoke("SceneChange2", 0.5f);
        //}
    }

    public void SceneChange()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage3 right");//������
    }

    public void SceneChange2()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage3 qestion");//�s������
    }
}
