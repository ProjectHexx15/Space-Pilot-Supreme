using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BCKGScroll : MonoBehaviour
{
    // variables

    public float backgroundSpeed; // stores the speed of the background
    public Renderer backgroundRenderer; // render of the background

    // Start is removed as it is not needed

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f); // infinite loop of background

    } // end of update

} // end of class
