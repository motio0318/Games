using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class secne : MonoBehaviour
{
    public void Title(string sceneName)
    {
        SceneManager.LoadScene("Taitole");
    }

    public void Compar(string sceneName)
    {
        SceneManager.LoadScene("Stage1");
    }

}