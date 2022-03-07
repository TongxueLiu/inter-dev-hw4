using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public Sprite sp1, sp2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        sr.sprite = sp2;
    }
    void OnMouseExit()
    {
        sr.sprite = sp1;
    }
    private void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "Level1":
                SceneManager.LoadScene("Level 1");
                break;
            case "Level2":
                SceneManager.LoadScene("Level 2");
                break;
            case "Level3":
                SceneManager.LoadScene("Level 3");
                break;
        }
    }
}
