using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Button firstButton;

    //variables that will hold each clothing item sprite to put on spencer
    //private List<Sprite> tops = new List<Sprite>(); 
    public Sprite[] tops; 
    public Sprite[] bottoms; 
    public Sprite[] hats; 

    //variables that will hold the icons of the clothing items
    public Sprite[] topsIcon;
    public Sprite[] bottomsIcon;
    public Sprite[] hatsIcon;

    public GameObject buttonPrefab;

    public Transform topsList;
    public Transform bottomsList;
    public Transform hatsList;

    public Image top;
    public Image bottom;
    public Image hat;

    // Start is called before the first frame update
    void Start()
    {
        tops = Resources.LoadAll<Sprite>("Clothes/Tops");
        bottoms = Resources.LoadAll<Sprite>("Clothes/Bottoms");
        hats = Resources.LoadAll<Sprite>("Clothes/Hats");

        topsIcon = Resources.LoadAll<Sprite>("Icons/Tops");
        bottomsIcon = Resources.LoadAll<Sprite>("Icons/Bottoms");
        hatsIcon = Resources.LoadAll<Sprite>("Icons/Hats");

        //create buttons for tops
        for (int i = 0; i < tops.Length; i++)
        {
            var button = Instantiate(buttonPrefab, topsList);
            button.GetComponent<SpriteLoad>().icon = topsIcon[i];
            button.GetComponent<SpriteLoad>().sprite = tops[i];
            button.GetComponent<SpriteLoad>().isTops = true;
        }

        //create buttons for bottoms
        for (int i = 0; i < bottoms.Length; i++)
        {
            var button = Instantiate(buttonPrefab, bottomsList);
            button.GetComponent<SpriteLoad>().icon = bottomsIcon[i];
            button.GetComponent<SpriteLoad>().sprite = bottoms[i];
            button.GetComponent<SpriteLoad>().isBottoms = true;
        }
        
        //create buttons for hats
        for (int i = 0; i < bottoms.Length; i++)
        {
            var button = Instantiate(buttonPrefab, hatsList);
            button.GetComponent<SpriteLoad>().icon = hatsIcon[i];
            button.GetComponent<SpriteLoad>().sprite = hats[i];
            button.GetComponent<SpriteLoad>().isHats = true;
        }

        if (firstButton != null)
        {
            firstButton.onClick.Invoke();
            firstButton.Select();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
