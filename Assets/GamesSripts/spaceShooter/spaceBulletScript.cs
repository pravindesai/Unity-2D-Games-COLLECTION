using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceBulletScript : MonoBehaviour
{
    public float BulletLife = 10;
    public float bulletSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletLife = BulletLife - Time.deltaTime;
        if(BulletLife <= 0)
        {
            Destroy(this.gameObject);
        }

        transform.position += Vector3.right * bulletSpeed * Time.deltaTime;
    }


}
