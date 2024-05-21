using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool canJump = true;
    MenuButtons menuButton;

    //private bool isJumping = false;
    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        menuButton = FindObjectOfType<MenuButtons>();
        if (menuButton == null)
        {
            Debug.LogError("MenuButtons script not found in this scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump && !menuButton.isPaused)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Ground")
        {
            canJump = true;
        }
    }
}
