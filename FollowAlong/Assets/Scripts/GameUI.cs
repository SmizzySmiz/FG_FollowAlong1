using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public delegate void Persistance();

    public static event Persistance SaveGame;
    public static event Persistance LoadGame;

    [SerializeField] private Image progressBar;
   // [SerializeField] private Button button;
    [SerializeField] private Button saveButton;
    [SerializeField] private Button loadButton;
    [SerializeField] private TextMeshProUGUI characterName;

    private void Start()
    {
       // button.onClick.AddListener(OnButtonPressed);
        saveButton.onClick.AddListener(SaveButtonClicked);
        loadButton.onClick.AddListener(LoadButtonClicked);

    }
        
    //public void OnButtonPressed()
    //{
    //    float randomValue = Random.Range(0f, 1f);
    //    progressBar.fillAmount = randomValue;
    //    progressBar.color = Color.green;
    //}

    private void SaveButtonClicked()
    {
        SaveGame();
    }

    private void LoadButtonClicked()
    {
        LoadGame();
    }
}
