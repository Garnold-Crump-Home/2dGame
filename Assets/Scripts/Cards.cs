using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Cards : MonoBehaviour
{
    public CardSelect CardSelect;
    public Button b1;
    public Button b2;
    public Button b3;
    public Sprite Card1;
    public Sprite Card2;
    public PlayerMovement PlayerMovement;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        int card1 = CardSelect.randomNumber;
        int card2 = CardSelect.randomNumber1;
        int card3 = CardSelect.randomNumber2;

        if (card1 == 1 || card2 == 1 || card3 == 1)
        {
            b1.image.sprite = Card1;
             b2.image.sprite = Card1;
            b3.image.sprite = Card1;
            if (CardSelect.clicked)
            {
                double health = PlayerMovement.playerMaxHealth;

                double percentAdd = 0.4 * health;
              int myint =  (int)health;
                
                health += PlayerMovement.playerMaxHealth;
            }
        }
        
        if (card1 == 2 || card2 == 2 || card3 == 2)
        {
            b1.image.sprite = Card2;
             b2.image.sprite = Card2;
            b3.image.sprite = Card2;
        }
    }
}
