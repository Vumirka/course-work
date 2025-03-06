using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    private Image buttonImage;
    public Sprite normalSprite;  // Спрайт для нормального стану кнопки
    public Sprite hoverSprite;   // Спрайт для кнопки при наведенні
    void Start() {
        buttonImage = GetComponent<Image>();
        // Встановлюємо спочатку спрайт для нормального стану
        buttonImage.sprite = normalSprite;
    }
    public void OnPointerEnter(PointerEventData eventData) {
        buttonImage.sprite = hoverSprite; // Змінюємо спрайт при наведенні
    }
    public void OnPointerExit(PointerEventData eventData) {
        buttonImage.sprite = normalSprite; // Відновлюємо спрайт при виході
    }
}