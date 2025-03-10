using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    private Image buttonImage;
    public Sprite normalSprite;  
    public Sprite hoverSprite;   
    void Start() {
        buttonImage = GetComponent<Image>();
        
        buttonImage.sprite = normalSprite;
    }
    public void OnPointerEnter(PointerEventData eventData) {
        buttonImage.sprite = hoverSprite; 
    }
    public void OnPointerExit(PointerEventData eventData) {
        buttonImage.sprite = normalSprite; 
    }
}