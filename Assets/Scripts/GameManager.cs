using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] FloatVariable score;
    [SerializeField] CanvasGroup losePanel;
    [SerializeField] CanvasGroup winPanel;

    private bool gameFinished;

    private void Start()
    {
        gameFinished = false;
    }

    private void Update()
    {
        if (gameFinished)
            return;

        
    }


    private void OnWin()
    {
       
        winPanel.gameObject.SetActive(true);
        StartCoroutine(FadeCanvasGroup(winPanel, 0, 1, .5f));
    }

    private void OnLose()
    {
       
        losePanel.gameObject.SetActive(true);
        StartCoroutine(FadeCanvasGroup(losePanel, 0, 1, .5f));
    }

    IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float duration)
    {
        float elapsed = 0f;
        while(elapsed < duration)
        {
            elapsed += Time.deltaTime;
            cg.alpha = Mathf.Lerp(start, end, elapsed / duration);
            yield return null;
        }
        cg.alpha = end;
    }
}
