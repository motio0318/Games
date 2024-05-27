using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI オブジェクトを扱う時は必須

public class Qcount : MonoBehaviour
{
    //beforQuestione beforQuestione;
    int Count;

    [SerializeField] Text VarTwxt;

    // Start is called before the first frame update
    void Start()
    {
        //beforQuestioneからcountを持ってくる
        Count = beforQuestione.i_beforQuestione.count;

        Debug.Log(beforQuestione.i_beforQuestione.count);

        QCount();
    }

    //第何問目をテキストにセットする
    void QCount()
    {
        Text Q　= VarTwxt;

        Q.text = "第"+ Count + "問目";
    }
}
