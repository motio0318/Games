using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class SChange : MonoBehaviour
{
    public void Title()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Title");
    }

    public void Describe()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Describe");
    }

    public void Explanation2()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Explanation2");
    }

}
