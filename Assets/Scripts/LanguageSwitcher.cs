using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitcher : MonoBehaviour {
    public Button languageButton;  // Кнопка, що показує випадаючий список
    public Dropdown languageDropdown;  // Випадаючий список для вибору мови
    public Text buttonText;  // Текст на кнопці для відображення активної мови

    private int currentLanguage = 0; // 0 - Українська, 1 - Англійська

    void Start() {
        languageDropdown.gameObject.SetActive(false);  // Приховати випадаючий список на початку
        languageDropdown.onValueChanged.AddListener(OnLanguageChanged);
        languageButton.onClick.AddListener(ToggleDropdown);
    }

    // Зміна мови при виборі з випадаючого списку
    void OnLanguageChanged(int index) {
        currentLanguage = index;
        UpdateLanguage();
        languageDropdown.gameObject.SetActive(false);  // Сховати список після вибору
    }

    // Перемикання видимості списку
    void ToggleDropdown() {
        languageDropdown.gameObject.SetActive(!languageDropdown.gameObject.activeSelf);
    }

    // Оновлення мови на кнопці та в грі
    void UpdateLanguage() {
        if (currentLanguage == 0) {
            buttonText.text = "UA";  // Показує "UA" на кнопці
            // Тут можна додати код для зміни текстів в грі на українську
        }
        else {
            buttonText.text = "EN";  // Показує "EN" на кнопці
            // Тут можна додати код для зміни текстів в грі на англійську
        }
    }
}
