using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class seane : MonoBehaviour
{
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "stage1")
        { // hogehoge�V�[���ł݂̂�肽������

        }
        else
        { // ����ȊO�̃V�[���ł�肽������

        }
    }
    public void Taitle()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Title");

    }

    public void stage01()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("stage1");
    }
    public void stage02()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage2");
    }
}