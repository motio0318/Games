using System.Threading;
using Unity.Mathematics;
using UnityEngine;

public class SpriteRendererSinExample : MonoBehaviour
{

    float Jikan = 5;
    


    // Destory������GameObject(��{�̓A�^�b�`���ꂽ����)
    public GameObject gameObject;


    // �_�ł�����Ώ�
    [SerializeField] private SpriteRenderer _target;

    // �_�Ŏ���[s]
    [SerializeField] private float _cycle = 1;

    private double _time;
    float timeElapsed;
    private void Update()
    {
       

        if (timeElapsed <= Jikan)
        {
            timeElapsed += Time.deltaTime;

            // �����������o�߂�����
            _time += Time.deltaTime;


           

            // ����cycle�ŌJ��Ԃ��g�̃A���t�@�l�v�Z
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.1f + 0.1f;

            // ��������time�ɂ�����A���t�@�l�𔽉f
            var color = _target.color;
            color.a = alpha;
            _target.color = color;
        }
        else
        {
            Destroy(gameObject);
            
        }

     

    }
}