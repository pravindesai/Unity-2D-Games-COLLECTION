using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Script : MonoBehaviour
{
    public Camera camera;
    public GameObject head;
    public GameObject bullet;
    public GameObject gunFront;
    public int bulleteSpeed = 2000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector3 worldPos = camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, transform.position.z - camera.transform.position.z));

        if(worldPos.x>head.transform.position.x + 1)
        {
            head.transform.localEulerAngles = new Vector3(
                head.transform.localEulerAngles.x,
                head.transform.localEulerAngles.y,
                Mathf.Atan2((worldPos.y - head.transform.position.y), (worldPos.x - head.transform.position.x)) * Mathf.Rad2Deg);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate(bullet);
            b.transform.position = gunFront.transform.position;
            b.GetComponent<Rigidbody2D>().AddForce(head.transform.right * bulleteSpeed);
        }

    }
}
