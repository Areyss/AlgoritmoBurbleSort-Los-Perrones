using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixCards : MonoBehaviour, IOperationCard
{
    public Vector2[] PerformOperation(Transform[] cards)
    {
        Vector2[] posicionesFinales = new Vector2[cards.Length]; // Declarar el array fuera del bucle

        for (int i = 0; i < cards.Length; i++)
        {
            int randomIndex = Random.Range(i, cards.Length);
            Vector2 tempPos = cards[i].position;
            cards[i].position = cards[randomIndex].position;
            cards[randomIndex].position = tempPos;

            // Guardar las posiciones finales después de la mezcla
            posicionesFinales[i] = cards[i].position;
        }

        // Retornar el array de posiciones finales
        return posicionesFinales;
    }
}
