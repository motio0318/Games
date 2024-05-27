using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I


public class beforQuestione : MonoBehaviour
{
    public static beforQuestione i_beforQuestione;

    public void Awake()
    {
        if (i_beforQuestione == null)
        {
            i_beforQuestione = this;
        }
    }

    public float Max = 10;
    Slider _slider;
    public int count = 0;

    void Start()
    {
        //DontDestroyOnLoad(this);

        // �X���C�_�[���擾����
        _slider = GameObject.Find("LoadBar").GetComponent<Slider>();

        count = PlayerPrefs.GetInt("count", 0);
        count += 1;//����ڂ�

        PlayerPrefs.SetInt("count", count);//�ۑ�

        //Debug.Log(count);
    }

    float _hp = 0;
    void Update()
    {
        // HP�㏸
        _hp += 0.01f;
        if (_hp > Max)
        {
            // �ő�𒴂�����0�ɖ߂�
            _hp = 0;


            //�V�[�����������ɓ���
            SceneManager.LoadScene("Stage3 qestion");

          
        }
        // HP�Q�[�W�ɒl��ݒ�
        _slider.value = _hp;
        //Debug.Log(count);
    }
}
