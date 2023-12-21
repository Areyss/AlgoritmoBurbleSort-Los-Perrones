using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCards : MonoBehaviour
{
    public Transform[] cards;
    public MixCards mezclarScript;
    public SortCards ordenarScript;

    private void Start()
    {
        // Asigna las referencias de los scripts si no se han asignado en el editor
        if (mezclarScript == null)
            mezclarScript = GetComponent<MixCards>();

        if (ordenarScript == null)
            ordenarScript = GetComponent<SortCards>();
    }

    public void Mezclar()
    {
        if (mezclarScript != null)
            StartCoroutine(MoveCards(mezclarScript.PerformOperation(cards)));
    }

    public void Ordenar()
    {
        if (ordenarScript != null)
            StartCoroutine(MoveCards(ordenarScript.PerformOperation(cards)));
    }

    private IEnumerator MoveCards(Vector2[] positionObjetive)
{
    float duracion = 1f; // Duración de la animación
    float tiempoInicio = Time.time;

    while (Time.time < tiempoInicio + duracion)
    {
        float t = (Time.time - tiempoInicio) / duracion;

        for (int i = 0; i < cards.Length; i++)
        {
            Vector2 positionInitial = cards[i].position;
            Vector2 positionObjetivee = positionObjetive[i];

            cards[i].position = Vector2.Lerp(positionInitial, positionObjetivee, t);
        }

        yield return null;
    }

    // Asegurarse de que la posición final sea exacta
    for (int i = 0; i < cards.Length; i++)
    {
        cards[i].position = positionObjetive[i];
    }
}
}
