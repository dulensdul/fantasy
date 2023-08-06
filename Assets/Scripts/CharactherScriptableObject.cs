using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Characther", menuName = "ScriptableObjects/Characther")]
public class CharactherScriptableObject : ScriptableObject
{
    public string navn;
    public Sprite charactherBillede;
    public Sprite AbilityQBillede;
    public Sprite AbilityWBillede;
    public Sprite AbilityEBillede;
    public Sprite AbilityRBillede;
    public Sprite AbilityPassiveBillede;

    public string ablityQText;
    public string ablityWText;
    public string ablityEText;
    public string ablityRText;
    public string ablityPassiveText;

    
    public string personlighed;


    public int Liv;
    public int BasicattackDamage;
}
