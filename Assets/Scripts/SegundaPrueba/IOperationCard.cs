using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOperationCard
{
    Vector2[] PerformOperation(Transform[] cards);
}
