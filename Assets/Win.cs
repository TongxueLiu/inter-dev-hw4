using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text titleText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LevelBeated());
    }

    IEnumerator LevelBeated()
    {
        titleText.text = "You Escaped!";
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
    }
}
