using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCharactherStats : MonoBehaviour
{
    public CharactherScriptableObject characther;

    public Image portrait;
    public Image ability1;
    public Image ability2;
    public Image ability3;

    public TextMeshProUGUI ability1Text;
    public TextMeshProUGUI ability2Text;
    public TextMeshProUGUI ability3Text;

    public new TextMeshProUGUI name;
    public TextMeshProUGUI personality;
    public TextMeshProUGUI health;

    public void UpdateStats(DisplayCharactherStats newCharactherData)
    {
        portrait.sprite = characther.charactherPortrait;
    }
}
