using UnityEngine;

/// <summary>
/// Đòn chém cận chiến: gây sát thương cho mọi quái trong bán kính.
/// Chuột trái hoặc phím J. Gắn vào Player.
/// </summary>
[RequireComponent(typeof(PlayerController))]
public class PlayerCombat : MonoBehaviour
{
    [Header("Tấn công")]
    public int damage = 20;
    public float attackRange = 1.2f;
    public float attackCooldown = 0.4f;

    [Tooltip("Chọn Layer 'Enemy' ở đây")]
    public LayerMask enemyLayer;

    float cooldownTimer;

    void Update()
    {
        if (cooldownTimer > 0f) cooldownTimer -= Time.deltaTime;

        bool attackPressed = Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.J);
        if (attackPressed && cooldownTimer <= 0f)
        {
            Attack();
            cooldownTimer = attackCooldown;
        }
    }

    void Attack()
    {
        // Đánh trúng mọi quái nằm trong bán kính attackRange thuộc enemyLayer
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyLayer);
        foreach (var hit in hits)
        {
            if (hit.TryGetComponent<Health>(out var health))
                health.TakeDamage(damage);
        }
    }

    // Vẽ vòng tầm đánh trong Scene khi chọn Player (bật Gizmos để thấy)
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
