using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaskOff : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr1, sr2;

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
        sr1.enabled = false;
        sr2.enabled = false;
        titleText.text = "Find the Way Out!";
    }
}
