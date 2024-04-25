using UnityEngine;
using System.Collections;
using UnityEngine.UI;//UI �I�u�W�F�N�g���������͕K�{
public class QuizMgr : MonoBehaviour
{

    //�A�^�b�`�����I�u�W�F�N�g���Ă΂ꂽ���Ɏ��s�����B
    void Start()
    {
        QuestionLabelSet();
        AnswerLabelSet();
    }

    private void QuestionLabelSet()
    {
        //����̖��O�̃I�u�W�F�N�g���������ăA�N�Z�X
        Text qLabel = GameObject.Find("Qize").GetComponentInChildren<Text>();
        //�f�[�^���Z�b�g���邱�ƂŁA���������㏑���ł���
        qLabel.text = "�����T�[�Y�N�͉���?";
    }

    private void AnswerLabelSet()
    {
        //�񓚕��ʂ̍쐬
        string[] array = new string[] { "10��", "6��", "���", "7��" };
        //�{�^����4����̂ł��ꂼ����
        for (int i = 1; i <= 4; i++)
        {
            Text ansLabel = GameObject.Find("ansButton" + i).GetComponentInChildren<Text>();
            ansLabel.text = array[i - 1];
        }
    }

}