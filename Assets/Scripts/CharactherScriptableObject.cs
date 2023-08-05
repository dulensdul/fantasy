using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Characther", menuName = "ScriptableObjects/Characther")]
public class CharactherScriptableObject : ScriptableObject
{
    public Sprite charactherPortrait;
    public Sprite Ability1;
    public Sprite Ability2;
    public Sprite Ability3;
    public Sprite Ability4;

    public string ablity1Text;
    public string ablity2Text;
    public string ablity3Text;
    public string ablity4Text;


    public new string name;
    public string personality;


    public int health;
}
