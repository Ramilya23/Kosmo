using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerImage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite defaultSprite; 
    public Sprite pointerSprite;
    public Image imageComponent;

public void OnPointerEnter(PointerEventData eventData)
    {
        imageComponent.sprite = pointerSprite; 
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        imageComponent.sprite = defaultSprite;
    }

    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }
}
