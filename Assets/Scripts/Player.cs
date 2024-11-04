using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public TMP_Text pvText;
    Rigidbody2D rb;
    float pv = 100f;
    private bool isWin;

    internal void Damage()
    {
        pv -= 20f;
    }

    internal void EatMelon()
    {
        pv += 20f;
        if (pv > 100)
        {
            pv = 100;
        }
    }

    internal void Freeze()
    {
        rb.bodyType = RigidbodyType2D.Static;
        isWin = true;
    }

    internal void Oxygenate()
    {
        pv += 10f * Time.deltaTime;
        if (pv > 100)
        {
            pv = 100;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isWin)
        {
            return;
        }

        pv -= Time.deltaTime;
        if (pv <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        pvText.text = $"PV: {(int)pv}";

        float x = Input.GetAxisRaw("Horizontal");
        var vel = rb.velocity;
        vel.x = x * 2f;
        rb.velocity = vel;

        if (x != 0)
        {
            spriteRenderer.flipX = x < 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5, ForceMode2D.Impulse);
        }
    }
}
