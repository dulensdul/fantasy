using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characther : MonoBehaviour
{
    public CharactherScriptableObject character;
    public DisplayCharactherStats display;

    void Start()
    {
        // Tilknyt knaptryk hændelse til vores OnClick metode
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Opdater vores DisplayCharactherStats med den tilknyttede karakter
        display.UpdateStats(character);
        display.OpenUI();
    }
}