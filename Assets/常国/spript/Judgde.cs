using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Judge : MonoBehaviour
{

    //�I�������{�^���̃e�L�X�g���x���Ɛ����̃e�L�X�g���r���Đ���𔻒�
    public void JudgeAnswer()
    {
        //�����̃f�[�^���e�L�X�g�ŃZ�b�g����
        string answerText = "7��";
        //�I�������{�^���̃e�L�X�g���x�����擾����
        Text selectedBtn = this.GetComponentInChildren<Text>();

        if (selectedBtn.text == "7��")
        {
            Debug.Log("����");
        }
        else
        {
            Debug.Log("�s����");
        }
    }
}