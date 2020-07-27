using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class UserInput : MonoBehaviour, IDragHandler
{
    public event Action<Vector2> LevelDragged;

    public void OnDrag(PointerEventData eventData)
    {
        LevelDragged?.Invoke(eventData.delta);
    }
}