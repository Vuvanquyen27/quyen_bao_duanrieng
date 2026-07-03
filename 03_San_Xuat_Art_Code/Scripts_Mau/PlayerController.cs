using UnityEngine;

/// <summary>
/// Di chuyển 8 hướng + lướt (dash) cho nhân vật top-down.
/// Gắn vào Player (cần Rigidbody2D). Dùng Input cũ -> nhớ đặt
/// Active Input Handling = Both trong Project Settings.
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Di chuyển")]
    public float moveSpeed = 5f;

    [Header("Lướt (Dash)")]
    public float dashSpeed = 15f;
    public float dashDuration = 0.15f;
    public float dashCooldown = 0.8f;

    Rigidbody2D rb;
    Vector2 moveInput;
    Vector2 lastMoveDir = Vector2.down; // hướng lướt khi đang đứng yên
    bool isDashing;
    float dashTimer;
    float cooldownTimer;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;      // top-down: không trọng lực
        rb.freezeRotation = true;  // không cho vật lý xoay nhân vật
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput = moveInput.normalized;
        if (moveInput != Vector2.zero) lastMoveDir = moveInput;

        if (cooldownTimer > 0f) cooldownTimer -= Time.deltaTime;

        bool dashPressed = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftShift);
        if (dashPressed && !isDashing && cooldownTimer <= 0f)
        {
            isDashing = true;
            dashTimer = dashDuration;
            cooldownTimer = dashCooldown;
        }
    }

    void FixedUpdate()
    {
        // Unity 6 dùng linearVelocity (bản cũ hơn dùng .velocity).
        if (isDashing)
        {
            rb.linearVelocity = lastMoveDir * dashSpeed;
            dashTimer -= Time.fixedDeltaTime;
            if (dashTimer <= 0f) isDashing = false;
        }
        else
        {
            rb.linearVelocity = moveInput * moveSpeed;
        }
    }
}
