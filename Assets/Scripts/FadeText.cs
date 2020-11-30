using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{
    public float fadeOutTime;

    private void Start()
    {
        FadeOut();
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutRoutine());
    }

    private IEnumerator FadeOutRoutine()
    {
        Text tapTxt = GetComponent<Text>();
        Color originalColor = tapTxt.color;
        Color fadeColor = new Color(1f, 1f, 1f, 0);

        while (true)
        {
            for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
            {
                tapTxt.color = Color.Lerp(originalColor, fadeColor, Mathf.Min(1, t / fadeOutTime));
                yield return null;
            }

            for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
            {
                tapTxt.color = Color.Lerp(fadeColor, originalColor, Mathf.Min(1, t / fadeOutTime));
                yield return null;
            }
        }

    }
}
