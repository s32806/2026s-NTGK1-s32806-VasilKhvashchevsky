using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 8f;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckDistance = 0.2f;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rb;
    private Animator an;
    private SpriteRenderer sr;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()

    {

        float moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        UpdateAnimations();
        Flip(moveInput);
    }
    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(
            groundCheck.position,
            Vector2.down,
            groundCheckDistance,
            groundLayer
        );
        return hit.collider != null;
    }
    private void UpdateAnimations() {
            an.SetFloat("XMovement", Mathf.Abs(rb.velocity.x));
            an.SetFloat("YMovement", Mathf.Abs(rb.velocity.y));
    }
    private void Flip(float moveInput) {
            if (moveInput > 0) {
                sr.flipX = false;
            } else if (moveInput < 0) {
                sr.flipX = true;
            }
    }
}