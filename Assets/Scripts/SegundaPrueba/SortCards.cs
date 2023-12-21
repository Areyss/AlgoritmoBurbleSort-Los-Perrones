using UnityEngine;

public class SortCards : MonoBehaviour, IOperationCard
{
    public Vector2[] PerformOperation(Transform[] cards)
    {
        int n = cards.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (cards[j].position.x > cards[j + 1].position.x)
                {
                    // Swap
                    Vector2 tempPos = cards[j].position;
                    cards[j].position = cards[j + 1].position;
                    cards[j + 1].position = tempPos;
                }
            }
        }

        Vector2[] posicionesFinales = new Vector2[cards.Length];
        for (int i = 0; i < cards.Length; i++)
        {
            posicionesFinales[i] = cards[i].position;
        }

        return posicionesFinales;
    }
}
