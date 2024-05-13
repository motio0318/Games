using System.Collections;
using TMPro;
using UnityEngine;

public class Gameover : MonoBehaviour
{
    [SerializeField] private TMP_Text tmpText;

    void Start()
    {
        StartCoroutine(Simple());
    }

    private IEnumerator Simple()
    {
        // �����̕\������0��(�e�L�X�g���\������Ȃ��Ȃ�)
        tmpText.maxVisibleCharacters = 0;

        // �e�L�X�g�̕����������[�v
        for (var i = 0; i < tmpText.text.Length; i++)
        {
            // �ꕶ�����Ƃ�0.2�b�ҋ@
            yield return new WaitForSeconds(0.2f);

            // �����̕\�����𑝂₵�Ă���
            tmpText.maxVisibleCharacters = i + 1;
        }
    }
}