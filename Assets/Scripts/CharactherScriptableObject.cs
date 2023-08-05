using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Characther", menuName = "CreateSomething/Characther")]
public class CharactherScriptableObject : MonoBehaviour
{
    public Sprite charactherPortrait;
    public Sprite Ability1;
    public Sprite Ability2;
    public Sprite Ability3;

    public string ablity1Text;
    public string ablity2Text;
    public string ablity3Text;

    public new string name;
    public string personality;


    public int health;
}
