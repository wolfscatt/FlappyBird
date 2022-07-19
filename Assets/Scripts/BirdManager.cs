using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdManager : MonoBehaviour
{
    public bool isDead = false;
    public float velocity = 1f;
    public GameManager gameManager;
    private Rigidbody2D rb2D;
    public GameObject DeathScreen;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("space") || Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Box")
        {
            gameManager.ScoreUpdate();
        }

        if (collision.CompareTag("PauseScreen"))
        {
            gameManager.PauseGame();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathBox")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
            gameManager.PlayScreen.SetActive(false);
        }
    }

}
