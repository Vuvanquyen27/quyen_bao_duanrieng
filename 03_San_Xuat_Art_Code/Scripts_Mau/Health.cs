using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Máu dùng chung cho Player và Enemy.
/// Móc UI/hiệu ứng vào onDamaged và onDied trong Inspector.
/// </summary>
public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int CurrentHealth { get; private set; }

    [Header("Sự kiện")]
    [Tooltip("(máu hiện tại, máu tối đa) — móc thanh máu UI vào đây")]
    public UnityEvent<int, int> onDamaged;
    [Tooltip("Gọi khi chết — móc hiệu ứng/âm thanh/game over vào đây")]
    public UnityEvent onDied;

    void Awake() => CurrentHealth = maxHealth;

    public void TakeDamage(int amount)
    {
        if (CurrentHealth <= 0) return;
        CurrentHealth = Mathf.Max(0, CurrentHealth - amount);
        onDamaged?.Invoke(CurrentHealth, maxHealth);

        if (CurrentHealth == 0)
        {
            onDied?.Invoke();
            Destroy(gameObject);
        }
    }

    public void Heal(int amount)
    {
        if (CurrentHealth <= 0) return;
        CurrentHealth = Mathf.Min(maxHealth, CurrentHealth + amount);
        onDamaged?.Invoke(CurrentHealth, maxHealth);
    }
}
