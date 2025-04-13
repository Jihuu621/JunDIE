using UnityEngine;

public class Player_Move1 : MonoBehaviour
{
    public bool isGround;
    Rigidbody2D rigid;
    public float jumpForce;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
