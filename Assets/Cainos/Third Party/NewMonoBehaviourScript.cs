using UnityEngine;
using UnityEngine.SceneManagement;  // For scene loading
using TMPro;  // For TMP Input Field

public class SceneTransition : MonoBehaviour
{
    public TMP_InputField inputField;  // Reference to the TMP Input Field
    public string correctWord = "Lollipop";  // The word that will allow scene transition

    // This method can be linked to the UI button's OnClick event
    public void OnButtonClick()
    {
        string userInput = inputField.text.ToLower();  // Get the text from the input field, case-insensitive

        if (userInput == correctWord.ToLower())  // If the input matches the correct word
        {
            SceneManager.LoadScene(10);  // Load Scene 10 (replace with the actual scene index)
        }
        else  // If the input is incorrect
        {
            SceneManager.LoadScene(11);  // Load Scene 11 (replace with the actual scene index)
        }

    }
}