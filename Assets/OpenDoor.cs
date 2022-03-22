using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public SpriteRenderer key;
    public GameObject keyToDestroy;

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
        if (key.enabled)
        {
            StartCoroutine(Open());
        }
    }

    IEnumerator Open()
    {
        yield return new WaitForSeconds(.4f);

        ad.Play(0);

        Destroy(keyToDestroy);

        key.enabled = false;

    }
}
