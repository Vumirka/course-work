using UnityEngine;
using UnityEngine.UI;

public class LanguageSwitcher : MonoBehaviour {
    public Button languageButton;  
    public Dropdown languageDropdown;  
    public Text buttonText;  

    private int currentLanguage = 0; 

    void Start() {
        languageDropdown.gameObject.SetActive(false);  
        languageDropdown.onValueChanged.AddListener(OnLanguageChanged);
        languageButton.onClick.AddListener(ToggleDropdown);
    }

    
    void OnLanguageChanged(int index) {
        currentLanguage = index;
        UpdateLanguage();
        languageDropdown.gameObject.SetActive(false);  
    }

    
    void ToggleDropdown() {
        languageDropdown.gameObject.SetActive(!languageDropdown.gameObject.activeSelf);
    }

    
    void UpdateLanguage() {
        if (currentLanguage == 0) {
            buttonText.text = "UA";  
            
        }
        else {
            buttonText.text = "EN";  
            
        }
    }
}
