using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class QuestionNext : MonoBehaviour
{
    private void Start()
    {

        Invoke("SceneChange", 5.0f);
    }

    public void SceneChange()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage3 qestion");
    }

}

