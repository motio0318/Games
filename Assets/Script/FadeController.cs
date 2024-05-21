using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{

    SpriteRenderer sp;
    Color spriteColor;
    float duratione = 1f;


    // Start is called before the first frame update
    void Start()
    {

        //sp = GetComponent();
        spriteColor = sp.color;
        StartCoroutine(Fade(0));


    }



    IEnumerator Fade(float targetAlpha)
    {
        while (!Mathf.Approximately(spriteColor.a, targetAlpha))
        {
            float changePerFrame = Time.deltaTime / duratione;
            spriteColor.a = Mathf.MoveTowards(spriteColor.a, targetAlpha, changePerFrame);
            sp.color = spriteColor;
            yield return null;
        }
    }
}
