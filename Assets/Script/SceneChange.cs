using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class SceneChange : MonoBehaviour
{
    public void LoadScene()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage1");
    }
}