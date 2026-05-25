using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsScroll : MonoBehaviour
{
    // Variables

    public float starSpeed; // Stores the speed of the Stars in the background
    public Renderer starRenderer; // Stores the StarRender

    // Start is removed as it is not needed

    // Update is called once per frame
    void Update()
    {
        starRenderer.material.mainTextureOffset += new Vector2(starSpeed * Time.deltaTime, 0f); // Repeats the StarRender
    } // End of Update

} // End of Class
