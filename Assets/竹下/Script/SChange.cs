using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class SChange : MonoBehaviour
{
    public void Title()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Taitole");
    }

    public void Explanation1()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Explanation1");
    }

    public void Explanation2()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Explanation2");
    }

}
