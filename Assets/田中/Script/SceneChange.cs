using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class SceneChange : MonoBehaviour
{
    public void stage01()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage1");
    }

    public void stage02()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage2");
    }
    public void stage03()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage3");
    }
}