using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI �I�u�W�F�N�g���������͕K�{

public class Qcount : MonoBehaviour
{
    //beforQuestione beforQuestione;
    int Count;

    [SerializeField] Text VarTwxt;

    // Start is called before the first frame update
    void Start()
    {
        //beforQuestione����count�������Ă���
        Count = beforQuestione.i_beforQuestione.count;

        Debug.Log(beforQuestione.i_beforQuestione.count);

        QCount();
    }

    //�扽��ڂ��e�L�X�g�ɃZ�b�g����
    void QCount()
    {
        Text Q�@= VarTwxt;

        Q.text = "��"+ Count + "���";
    }
}
