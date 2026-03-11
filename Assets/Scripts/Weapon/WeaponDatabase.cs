using System.Collections.Generic;
using UnityEngine;

public class WeaponDatabase : MonoBehaviour
{
    public static WeaponDatabase Instance { get; private set; }

    [SerializeField] private List<WeaponSO> weaponDataList;

    private void Awake()
    {
        // Simple Singleton pattern for easy global access
        if (Instance == null) Instance = this;
        else Destroy(gameObject);


    }

    public Weapon CreateWeaponInstance(int weaponId, Transform parent = null)
    {
        if (!weaponDataList.Exists(s => s.Id == weaponId))
        {
            Debug.LogWarning($"WeaponSO with id {weaponId} not found");
            return null;
        }

        WeaponSO data = weaponDataList.Find(s => s.Id == weaponId);

        GameObject go = new GameObject($"Weapon_Instance_{data.WeaponName}");
        if (parent != null) go.transform.SetParent(parent, false);

        Weapon instance = null;
        switch (data.WeaponKind)
        {
            case WeaponType.Melee:
                var melee = go.AddComponent<MeleeWeapon>();
                melee.Build(data);
                instance = melee;
                break;
            case WeaponType.Projectile:
                var proj = go.AddComponent<ProjectileWeapon>();
                proj.Build(data);
                instance = proj;
                break;
        }

        return instance;
    }
}