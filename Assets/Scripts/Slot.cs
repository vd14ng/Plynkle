using UnityEngine;

public class Slot : MonoBehaviour
{
    public UI Ui;
    public int points = 10;
    public void OnTriggerEnter2D(Collider2D other)
    {
        // print("OnTriggerEnter2D");
        if (other.CompareTag("Ball"))
        {
            OnBallEntered(other);
            Destroy(other.gameObject);
        }
    }
    
    // when ball enters the slot, you score points
    private void OnBallEntered(Collider2D other)
    {
        // print("OnBallEntered");
        ScorePoints();
    }
    private void ScorePoints()
    {
        // tell the scorekeeper to add some amount of points
        ScoreKeeper.Add(points);
        Ui.ShowScore(ScoreKeeper.GetScore());
    }
}
