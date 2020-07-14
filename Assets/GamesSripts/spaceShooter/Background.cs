using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float ScrollSpeed = 0.3f;
    Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset = new Vector2(Time.time * ScrollSpeed, 0f);
    }

    
}
