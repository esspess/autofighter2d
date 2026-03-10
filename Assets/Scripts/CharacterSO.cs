using UnityEngine;

[CreateAssetMenu(fileName = "CharacterSO", menuName = "Scriptable Objects / CharacterSO")]
public class CharacterSO : ScriptableObject
{
    public int Id;
    public string CharacterName;
    public Sprite CharacterSprite;
}
