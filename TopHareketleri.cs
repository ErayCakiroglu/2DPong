using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class TopHareketleri : MonoBehaviour
{
    [SerializeField] Rigidbody2D top;
    [SerializeField] float xHizi, yHizi;
    [SerializeField] TextMeshProUGUI player1SkorYazisi, player2SkorYazisi, kazananYazisi, bitisYazisi;
    [SerializeField] int player1Skor, player2Skor;
    [SerializeField] AudioSource skorMuzigi, kazanmaSesi;
    int maxSkor = 2;

    void Start()
    {
        top.velocity = new Vector2(Random.Range(7, 10), Random.Range(5, 8));
    }
    void Update()
    {
        player1SkorYazisi.text = player1Skor.ToString();
        player2SkorYazisi.text = player2Skor.ToString();
        if(Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Player1")
        {
            top.velocity = new Vector2(-xHizi, Random.Range(-3f, 3f));
        }

        if(temas.gameObject.tag == "Player2")
        {
            top.velocity = new Vector2(xHizi, Random.Range(-3f, 3f));
        }

        if(temas.gameObject.tag == "UstDuvar")
        {
            top.velocity = new Vector2(top.velocity.x, -yHizi);
        }

        if(temas.gameObject.tag == "AltDuvar")
        {
            top.velocity = new Vector2(top.velocity.x, yHizi);
        }

        if(temas.gameObject.tag == "SolDuvar")
        {
            top.velocity = new Vector2(Random.Range(7, 10), Random.Range(3, 5));
            player1Skor++;
            skorMuzigi.Play();
        }
        else if(temas.gameObject.tag == "SagDuvar")
        {
            top.velocity = new Vector2(Random.Range(-7, -10), Random.Range(3, 5));
            player2Skor++;
            skorMuzigi.Play();
        }
            
        if(player1Skor == maxSkor)
        {
            kazananYazisi.text = "Player1 win, congrulations.";
            kazanmaSesi.Play();
            bitisYazisi.text = "Press Enter to play again.";
            Time.timeScale = 0;
        }

        if(player2Skor == maxSkor)
        {
            kazananYazisi.text = "Player2 win, congrulations.";
            kazanmaSesi.Play();
            bitisYazisi.text = "Press Enter to play again.";
            Time.timeScale = 0;
        }
    }
}
