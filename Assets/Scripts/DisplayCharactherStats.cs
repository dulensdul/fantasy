using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCharactherStats : MonoBehaviour
{
    public GameObject background;

    public CharactherScriptableObject characther;

    public new TextMeshProUGUI name;
    public Image portrait;
    public Image abilityQ;
    public TextMeshProUGUI abilityQText;
    public Image abilityW;
    public TextMeshProUGUI abilityWText;
    public Image abilityE;
    public TextMeshProUGUI abilityEText;
    public Image abilityR;
    public TextMeshProUGUI abilityRText;

    public TextMeshProUGUI personality;
    public TextMeshProUGUI health;

    public void UpdateStats(CharactherScriptableObject newCharactherData)
    {
        characther = newCharactherData;

        portrait.sprite = characther.charactherPortrait;
        abilityQ.sprite = characther.Ability1;
        abilityW.sprite = characther.Ability2;
        abilityE.sprite = characther.Ability3;
        abilityR.sprite = characther.Ability4;

        abilityQText.text = characther.ablity1Text;
        abilityWText.text = characther.ablity2Text;
        abilityEText.text = characther.ablity3Text;
        abilityRText.text = characther.ablity4Text;

        name.text = characther.name;
        personality.text = characther.personality;
        health.text = characther.health.ToString();
    }

    public void OpenUI()
    {
        background.SetActive(true);
    }

    public void CloseUI()
    {
        background.SetActive(false);
    }
}
