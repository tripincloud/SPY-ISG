using UnityEngine;

public class ActivityPortal : MonoBehaviour
{
    // Serialized field to set the URL in the Unity Editor
    [SerializeField]
    private string serializedWebpageURL = "https://www.google.com/";

    // Public property to get the URL (read-only)
    public string WebpageURL
    {
        get { return serializedWebpageURL; }
    }

    // Method to be called when the button is clicked
    public void OpenWebPageOnClick()
    {
        // Open the URL in the default web browser
        Application.OpenURL(serializedWebpageURL);
    }
}
