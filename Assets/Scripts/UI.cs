using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    public CanvasGroup StartMenuCanvasGroup;
    public void ShowScore(int score)
    {
        // print(score);
        ScoreText.text = score.ToString();
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
    }
}
