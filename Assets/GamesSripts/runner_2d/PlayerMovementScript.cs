using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    public float rightForce = 200; 
    public float jumpForce = 300; 
    public Boolean canJump = true; 
    public int score = 0; 
    int step = 10; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= step)
        {
            score = (int)Time.time;
            step = step + 10;
            rightForce = rightForce + 20;
            Debug.Log("Speed Increased");
        }
        else
        {
            score = (int)Time.time;
        }

       // transform.GetComponent<Rigidbody2D>().AddForce(transform.right * rightForce * Time.deltaTime);

        if (Input.GetKeyDown("right"))
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(rightForce, 0));
        }

        if (Input.GetKeyDown("left"))
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(-rightForce, 0));
        }

        if (Input.GetKeyDown("space") && canJump)
         {
        transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            canJump = false;
         }

        if (Input.GetKey("r") )
        {
            restartGame();
        }

    }

    private void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);
        canJump = true;
    }
}
