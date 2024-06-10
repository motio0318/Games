using System.Threading;
using Unity.Mathematics;
using UnityEngine;

public class SpriteRendererSinExample : PHP
{

    float Jikan = 5;
    public GameObject red_cnt;
    


    // DestoryしたいGameObject(基本はアタッチされたもの)
    public GameObject gameObject;


    // 点滅させる対象
    [SerializeField] private SpriteRenderer _target;

    // 点滅周期[s]
    [SerializeField] private float _cycle = 1;

    private double _time;
    float timeElapsed;
    private void Update()
    {


        if (PHP.P_Hp == 1)
        {
            this.red_cnt.SetActive(true);

            if (timeElapsed <= Jikan)
            {
                timeElapsed += Time.deltaTime;

                // 内部時刻を経過させる
                _time += Time.deltaTime;




                // 周期cycleで繰り返す波のアルファ値計算
                var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.1f + 0.1f;

                // 内部時刻timeにおけるアルファ値を反映
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
}