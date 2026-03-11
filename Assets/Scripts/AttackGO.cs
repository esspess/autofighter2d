using UnityEngine;

public class AttackGO : MonoBehaviour
{
    public Weapon currentWeapon;
    private float nextAvailableAttackTime = 0f;

    public void SetWeapon(Weapon newWeapon)
    {
        currentWeapon = newWeapon;
    }

    // Call this from CharacterGO (e.g., when the player clicks)
    public void TryAttack()
    {
        if (currentWeapon == null) return;
        // Check if enough time has passed based on the weapon's fire rate
        if (Time.time >= nextAvailableAttackTime)
        {

            // We don't care if it's melee or projectile, we just call Attack()
            currentWeapon.Attack();

            // Calculate when we can attack next (e.g., if fireRate is 0.5, we wait half a second)
            nextAvailableAttackTime = Time.time + currentWeapon.FireRate;
        }
    }
}