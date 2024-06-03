using UnityEngine;
using UnityEngine.UI;

public class tenmetu: MonoBehaviour
{
    // 点滅させる対象
    [SerializeField] private Text _target;

    // 時系列のアルファ値の変化カーブ
    [SerializeField] private AnimationCurve _alphaCurve = AnimationCurve.Linear(0, 0, 1, 1);

    private float _cycle;
    private double _time;

    private void Start()
    {
        var length = _alphaCurve.length;
        if (length < 1)
            return;

        _cycle = _alphaCurve.keys[length - 1].time;
    }

    private void Update()
    {
        // 内部時刻を経過させる
        _time += 0.001;

       
        // アニメーションカーブに従ったアルファ値計算
        var alpha = _alphaCurve.Evaluate((float)_time);

        // 内部時刻timeにおけるアルファ値を反映
        var color = _target.color;
        color.a = alpha;
        _target.color = color;
    }
}