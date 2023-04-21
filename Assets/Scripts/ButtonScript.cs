using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool held = false;

    public void OnPointerUp(PointerEventData data)
    {
        held = false;
    }

    public void OnPointerDown(PointerEventData data)
    {
        held= true;
    }
}
