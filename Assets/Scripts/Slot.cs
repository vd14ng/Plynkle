using UnityEngine;

public class Slot : MonoBehaviour
{
    public int Points = 10;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlotTrigger"))
        {
            Destroy(gameObject);
        }
    }

    private void OnBallEntered(Collider2D other)
    {
        ScorePoints();
    }

    private void ScorePoints()
    {
        // tell the scorekeeper to add some amount of points
        
        
    }
}
