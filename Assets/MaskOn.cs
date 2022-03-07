using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaskOn : MonoBehaviour
{

    public SpriteRenderer lightSr, noLightSr;
    public SpriteRenderer flashlight;

    public TMP_Text titleText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (flashlight.enabled)
        {
            lightSr.enabled = true;
        } else
        {
            titleText.text = "Too Dark!";
            noLightSr.enabled = true;
        }
    }

}
