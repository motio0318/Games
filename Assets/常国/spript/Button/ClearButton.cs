using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �V�[���؂�ւ�����Ƃ��͖Y��Ȃ��I�I

public class ClearButton : MonoBehaviour
{
    [SerializeField, Header("���艹")]
    private GameObject submitSE;

    //�{�^���������ꂽ��
    public void OnClick()
    {
        //SE�炷
        Instantiate(submitSE);

        //10�b��ɌĂяo��
        Invoke("SceneChange", 10);
    }

    public void SceneChange()
    {
        //�^�C�g���V�[����
        SceneManager.LoadScene("Title");
    }
}

