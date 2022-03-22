using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRedKey : MonoBehaviour
{
    public GameObject redKey;
    public SpriteRenderer sr;

    public AudioSource ad;
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
        if (ad != null)
        {
            ad.Play(0);
        }
        Destroy(redKey);

        StartCoroutine(EnableUI());
    }

    IEnumerator EnableUI()
    {
        sr.enabled = true;
        yield return null;
    }

}
