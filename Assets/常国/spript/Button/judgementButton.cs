using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 忘れない！！

public class judgementButton : MonoBehaviour
{
    [SerializeField, Header("決定音")]
    private GameObject submitSE;

    private void Start()
    {
        Instantiate(submitSE);

        /*if(//もしCSVファイルのselect3が押されたら)
         {
             Invoke("SceneChange", 5.0f);
         }
        */
        /*else if (//CSVファイルのselect1,CSVファイルのselect2,CSVファイルのselect4が押されたら)
        {
            Invoke("SceneChange2", 5.0f);
        }*/

    }

    public void SceneChange()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3 qestion");//正解へ
    }

    public void SceneChange2()
    {
        //シーン名をここに入力
        SceneManager.LoadScene("Stage3 qestion");//不正解へ
    }
}
