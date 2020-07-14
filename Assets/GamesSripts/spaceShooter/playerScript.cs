using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour
{
    public Camera camera;
    public float speed = 3f;
    public GameObject bullet;
    public GameObject gunHead;
    public GameObject enemy;
    float timer = 3;
    public int enemySpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bullet);
            b.transform.position = gunHead.transform.position;
            b.transform.SetParent(GameObject.Find("bulletCollection").transform);
        }

        

        timer = timer - Time.deltaTime;
        //Debug.Log(timer);
        if(timer <= 0)
        {
            timer = enemySpeed;
            GameObject b = Instantiate(enemy);
            b.transform.position = new Vector3(10,Random.Range(4, -4)  ,0);
            b.transform.SetParent(GameObject.Find("bulletCollection").transform);
        }
    }

}
