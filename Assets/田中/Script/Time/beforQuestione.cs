using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I


public class beforQuestione : MonoBehaviour
{
    public float Max = 10;
    Slider _slider;
    void Start()
    {
        // �X���C�_�[���擾����
        _slider = GameObject.Find("LoadBar").GetComponent<Slider>();
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
    }
}
