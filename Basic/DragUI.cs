using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image objectImage;
    private Vector2 beginPosition;
    private Color32 objectColor;

    // 오브젝트를 눌렀을 시
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        objectColor = objectImage.color;
        objectImage.color = objectImage.color - new Color32(0, 0, 0, 50);
        Debug.Log("OnPointerDown");
    }

    // 오브젝트를 놓았을 시
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        objectImage.color = objectColor;
        Debug.Log("OnPointerUp");
    }

    // 끌기 시작 시
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        beginPosition = transform.position;
        objectImage.color = objectImage.color - new Color32(0, 0, 0, 50);
        Debug.Log("OnBeginDrag");
    }

    // 끄는 도중
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        Debug.Log("OnDrag");
    }

    // 끌기가 끝날 때
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }
}
