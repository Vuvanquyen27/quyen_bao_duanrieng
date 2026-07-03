using UnityEngine;

/// <summary>
/// Quái đứng yên; thấy Player trong sightRange thì đuổi;
/// vào attackRange thì cắn theo nhịp attackCooldown.
/// Gắn vào Enemy (cần Rigidbody2D). Player phải có Tag = "Player".
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyAI : MonoBehaviour
{
    [Header("Tầm nhìn & di chuyển")]
    public float sightRange = 5f;
    public float moveSpeed = 2.5f;

    [Header("Tấn công")]
    public float attackRange = 1f;
    public int damage = 10;
    public float attackCooldown = 1f;

    Rigidbody2D rb;
    Transform player;
    float cooldownTimer;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.freezeRotation = true;

        var playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null) player = playerObj.transform;
    }

    void FixedUpdate()
    {
        if (player == null) return;

        float dist = Vector2.Distance(transform.position, player.position);

        if (dist <= attackRange)
        {
            rb.linearVelocity = Vector2.zero;
            TryAttack();
        }
        else if (dist <= sightRange)
        {
            Vector2 dir = ((Vector2)player.position - rb.position).normalized;
            rb.linearVelocity = dir * moveSpeed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }

    void TryAttack()
    {
        cooldownTimer -= Time.fixedDeltaTime;
        if (cooldownTimer > 0f) return;
        cooldownTimer = attackCooldown;

        if (player.TryGetComponent<Health>(out var health))
            health.TakeDamage(damage);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
