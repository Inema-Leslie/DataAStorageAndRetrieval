using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerPrefsManager : MonoBehaviour
{
    [Header("Input Fields")]
    public TMP_InputField scoreInput;
    public TMP_InputField volumeInput;
    public TMP_InputField usernameInput;

    [Header("Buttons")]
    public Button saveButton;
    public Button loadButton;
    public Button deleteButton;

    [Header("Display Texts")]
    public TMP_Text scoreDisplay;
    public TMP_Text volumeDisplay;
    public TMP_Text usernameDisplay;
    public TMP_Text statusText;

    void Start()
    {
        saveButton.onClick.AddListener(SaveData);
        loadButton.onClick.AddListener(LoadData);
        deleteButton.onClick.AddListener(DeleteData);
        LoadData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("HighScore", int.Parse(scoreInput.text));
        PlayerPrefs.SetFloat("Volume", float.Parse(volumeInput.text));
        PlayerPrefs.SetString("Username", usernameInput.text);
        PlayerPrefs.Save();
        statusText.text = "Data Saved!";
        RefreshDisplays();
    }

    public void LoadData()
    {
        scoreInput.text    = PlayerPrefs.GetInt("HighScore", 0).ToString();
        volumeInput.text   = PlayerPrefs.GetFloat("Volume", 1f).ToString();
        usernameInput.text = PlayerPrefs.GetString("Username", "Player");
        RefreshDisplays();
        statusText.text = "Data Loaded!";
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("HighScore");
        PlayerPrefs.DeleteKey("Volume");
        PlayerPrefs.DeleteKey("Username");
        PlayerPrefs.Save();
        scoreInput.text = "";
        volumeInput.text = "";
        usernameInput.text = "";
        RefreshDisplays();
        statusText.text = "Data Deleted!";
    }

    void RefreshDisplays()
    {
        scoreDisplay.text    = "High Score: " + PlayerPrefs.GetInt("HighScore", 0);
        volumeDisplay.text   = "Volume: "     + PlayerPrefs.GetFloat("Volume", 1f);
        usernameDisplay.text = "Username: "   + PlayerPrefs.GetString("Username", "Player");
    }
}
