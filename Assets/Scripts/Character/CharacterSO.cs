using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects / CharacterSO")]
public class CharacterSO : ScriptableObject
{
    public int Id;
    public string CharacterName;
    public Sprite CharacterSprite;
    // public AttackGO CharacterAttack;
    public int CharacterHealth;
}
