using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class enemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeed= 3;
    static int Score = 0 ;
    Text ScoreText;
    void Start()
    {
        ScoreText = GameObject.Find ("Canvas/scoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * enemySpeed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Restart game
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Score = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        ScoreText.text = (++Score).ToString();

        if (collision.collider.name == "spaceship") {
            Debug.Log("Game Ended");
            ScoreText.text = "Final Score : "+Score;
        }

        Destroy(this.gameObject);
        Destroy(collision.gameObject);

    }

}
