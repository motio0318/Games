using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I


public class beforQuestione : MonoBehaviour
{
    Slider _slider;
    void Start()
    {
        // �X���C�_�[���擾����
        _slider = GameObject.Find("HPbar").GetComponent<Slider>();
    }

    float _hp = 0;
    void Update()
    {
        // HP�㏸
        _hp += 0.01f;
        if (_hp > 16)
        {
            // �ő�𒴂�����0�ɖ߂�
            _hp = 0;
        }

        // HP�Q�[�W�ɒl��ݒ�
        _slider.value = _hp;
    }
}
