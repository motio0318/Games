using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundScript : MonoBehaviour
{
    private static SoundScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            // このオブジェクトがシングルトンのインスタンスとして設定される
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 既にインスタンスが存在する場合、このオブジェクトを破棄
            Destroy(gameObject);
        }
        
    }

    public AudioSource A_BGM;//AudioSource型の変数A_BGMを宣言　対応するAudioSourceコンポーネントをアタッチ
    private string beforeScene;//string型の変数beforeSceneを宣言 

    public void Start()
    {
        beforeScene = "Title";
        A_BGM.Play();//A_BGMのAudioSourceコンポーネントに割り当てたAudioClipを再生
        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;

    }
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        if (beforeScene == "Title" && nextScene.name == "Stage")
            A_BGM.Stop();
    }
}
