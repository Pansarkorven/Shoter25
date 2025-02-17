using StarterAssets;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{
    [SerializeField] WeaponSO weaponSO;

    StarterAssetsInputs starterAssetInputs;
    Animator animator;
    Weapon currentWeapon;

    const string SHOOT_STRING = "shoot";

    void Awake()
    {
        starterAssetInputs = GetComponentInParent<StarterAssetsInputs>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        currentWeapon = GetComponentInChildren<Weapon>();
    }

    void Update()
    {
        HandleShoot();
    }

    void HandleShoot()
    {
        if (!starterAssetInputs.Shoot) { return; }

        animator.Play(SHOOT_STRING, 0, 0f);
        currentWeapon.Shoot(weaponSO);

        starterAssetInputs.ShootInput(false);
    }
}