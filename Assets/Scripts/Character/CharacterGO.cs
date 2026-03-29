using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterGO : MonoBehaviour, IDamagable
{
    [SerializeField] StateMachine characterStateMachine;
    [SerializeField] CharacterWaitingState characterWaitingState;
    public enum CharacterState
    {
        None = -1,
        Waiting = 0,
        Patrol,
        Attack,
        Dead
    }
    public void ChangeState(CharacterState newState)
    {
        switch (newState)
        {
            case CharacterState.Waiting:
                characterStateMachine.SetCurrentState(characterWaitingState);
                break;
            case CharacterState.Patrol:
                // characterStateMachine.SetCurrentState(new CharecterPatrolState());
                break;
            case CharacterState.Attack:
                // characterStateMachine.SetCurrentState(new CharacterAttackState());
                break;
            case CharacterState.Dead:
                // characterStateMachine.SetCurrentState(new CharacterDeadState());
                break;
        }
    }
    private AttackGO attackGO;
    private Health characterHealth;
    Keyboard keyboard;
    Vector2 randomDirection;
    [SerializeField] LayerMask whatIsBoundary;
    // Find the collider

    private void Awake()
    {
        attackGO = GetComponent<AttackGO>();
        characterHealth = new Health();
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
        // Set A Random Direction
        randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }
    public void WalkRandomly()
    {
        transform.Translate(randomDirection * Time.deltaTime * 2f); // Move at a speed of 2 units per second
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        ContactPoint2D[] contacts = new ContactPoint2D[10];
        collision.GetContacts(contacts);
        if ((whatIsBoundary.value & (1 << collision.gameObject.layer)) != 0)
        {
            Debug.Log(gameObject.name + " hit a boundary!");
            Vector2 ReflectedDirection = Vector2.Reflect(randomDirection, contacts[0].normal);
            randomDirection = -1 * ReflectedDirection;
        }
    }
    public void TakeDamage(float amount)
    {
        characterHealth.TryTakeDamage(amount);
    }
}