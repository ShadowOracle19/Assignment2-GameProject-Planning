using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteLoad : MonoBehaviour
{
    public Sprite sprite;
    public Sprite icon;

    public Image iconImage;

    public bool isTops = false;
    public bool isBottoms = false;
    public bool isHats = false;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        iconImage.sprite = icon;
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress()
    {
        if(isTops)
        {
            gameManager.top.gameObject.SetActive(true);
            gameManager.top.sprite = sprite;
        }
        else if(isBottoms)
        {
            gameManager.bottom.gameObject.SetActive(true);
            gameManager.bottom.sprite = sprite;
        }
        else if(isHats)
        {
            gameManager.hat.gameObject.SetActive(true);
            gameManager.hat.sprite = sprite;
        }
    }
}
