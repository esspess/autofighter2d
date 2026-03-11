using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterGO : MonoBehaviour, IDamagable
{
    private AttackGO attackGO;
    private Health CharacterHealth;
    Keyboard keyboard;

    public void TakeDamage(float amount)
    {
        CharacterHealth.TryTakeDamage(amount);
    }

    private void Awake()
    {
        attackGO = GetComponent<AttackGO>();
        CharacterHealth = new Health();
    }

    private void Start()
    {
        keyboard = Keyboard.current;
        // Example: Equip weapon ID 1 from the database when the game starts
        // 1. Get the "Master" reference from the database
        Weapon weaponClone = WeaponDatabase.Instance.CreateWeaponInstance(1, this.transform);
        if (weaponClone != null)
        {
            weaponClone.transform.localPosition = Vector3.zero;
            attackGO.SetWeapon(weaponClone);
        }
    }

    private void Update()
    {
        // Example Input
        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            attackGO.TryAttack();
        }

    }
}