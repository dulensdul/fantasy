using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCharactherStats : MonoBehaviour
{
    public GameObject background;

    public CharactherScriptableObject characther;

    public TextMeshProUGUI navn;
    public Image portrait;
    public Image abilityQ;
    public TextMeshProUGUI abilityQText;
    public Image abilityW;
    public TextMeshProUGUI abilityWText;
    public Image abilityE;
    public TextMeshProUGUI abilityEText;
    public Image abilityR;
    public TextMeshProUGUI abilityRText;
    public Image abilityPassive;
    public TextMeshProUGUI abilityPassiveText;

    public TextMeshProUGUI personality;
    public TextMeshProUGUI health;
    public TextMeshProUGUI attackDamage;

    public void UpdateStats(CharactherScriptableObject newCharactherData)
    {
        characther = newCharactherData;

        portrait.sprite = characther.charactherBillede;
        abilityQ.sprite = characther.AbilityQBillede;
        abilityW.sprite = characther.AbilityWBillede;
        abilityE.sprite = characther.AbilityEBillede;
        abilityR.sprite = characther.AbilityRBillede;
        abilityPassive.sprite = characther.AbilityPassiveBillede;

        abilityQText.text = characther.ablityQText;
        abilityWText.text = characther.ablityWText;
        abilityEText.text = characther.ablityEText;
        abilityRText.text = characther.ablityRText;
        abilityPassiveText.text = characther.ablityPassiveText;

        navn.text = characther.navn;
        personality.text = characther.personlighed;
        health.text = characther.Liv.ToString();
        attackDamage.text = characther.BasicattackDamage.ToString();
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
