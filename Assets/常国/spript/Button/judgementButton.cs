using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class judgementButton : MonoBehaviour
{
    [SerializeField, Header("���艹")]
    private GameObject submitSE;

    private void Start()
    {
        Instantiate(submitSE);

        /*if(//����CSV�t�@�C����select3�������ꂽ��)
         {
             Invoke("SceneChange", 5.0f);
         }
        */
        /*else if (//CSV�t�@�C����select1,CSV�t�@�C����select2,CSV�t�@�C����select4�������ꂽ��)
        {
            Invoke("SceneChange2", 5.0f);
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
