
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public int h1;
    public Canvas canvas;
    public Transform player1;
    public float groudIncrease = 0;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Cards") { canvas.enabled = true; b1.enabled = true; b2.enabled = true; b3.enabled = true; }
        if (sceneName != "Cards") { canvas.enabled = false; b1.enabled = false; b2.enabled = false; b3.enabled = false; }
        int card1 = CardSelect.randomNumber;
        int card2 = CardSelect.randomNumber1;
        int card3 = CardSelect.randomNumber2;

        if (card1 == 1)
        {
            b1.image.sprite = Card1;
          
            if (CardSelect.clicked)
            {
                int health = PlayerMovement.playerMaxHealth * 4;
                int h = health / 10;
                h += PlayerMovement.playerMaxHealth;
                PlayerMovement.playerMaxHealth = h;
                PlayerMovement.playerHealth = PlayerMovement.playerMaxHealth;
                float speed = PlayerMovement.moveSpeed * 25;
                float speed1 = speed / 100;
                PlayerMovement.moveSpeed -= speed1;
                float x = player1.localScale.x;

                if (x < 0)
                {
                    player1.localScale += new Vector3(-1, 1, 1);
                    CardSelect.clicked = false;
                }
                else if (x > 0)
                {
                    player1.localScale += new Vector3(1, 1, 1);
                    CardSelect.clicked = false;
                }

                float i = player1.localScale.y;
                float j = i * 16 / 100;
                groudIncrease = j;

                PlayerMovement.groundCheckRadius = groudIncrease;
                CardSelect.clicked = false;
                


            }
        }

        else if  (card2 == 1)
        {
           
            b2.image.sprite = Card1;
            
            if (CardSelect.clicked2)
            {
                int health = PlayerMovement.playerMaxHealth * 4;
                int h = health / 10;
                h += PlayerMovement.playerMaxHealth;
                PlayerMovement.playerMaxHealth = h;
                PlayerMovement.playerHealth = PlayerMovement.playerMaxHealth;
                float speed = PlayerMovement.moveSpeed * 25;
                float speed1 = speed / 100;
                PlayerMovement.moveSpeed -= speed1;
               

                float x = player1.localScale.x;

                if (x < 0)
                {
                    player1.localScale += new Vector3(-1, 1, 1);
                    CardSelect.clicked2 = false;
                }
                else if (x > 0)
                {
                    player1.localScale += new Vector3(1, 1, 1);
                    CardSelect.clicked2 = false;
                }

                float i = player1.localScale.y;
                float j = i * 16 / 100;
                groudIncrease = j;

                PlayerMovement.groundCheckRadius = groudIncrease;
                CardSelect.clicked2 = false;



            }
        }
        else if (card3 == 1)
        {
          
            b3.image.sprite = Card1;
            if (CardSelect.clicked3)
            {
                int health = PlayerMovement.playerMaxHealth * 4;
                int h = health / 10;
                h += PlayerMovement.playerMaxHealth;
                PlayerMovement.playerMaxHealth = h;
                PlayerMovement.playerHealth = PlayerMovement.playerMaxHealth;
                float speed = PlayerMovement.moveSpeed * 25;
                float speed1 = speed / 100;
                PlayerMovement.moveSpeed -= speed1;

                float x = player1.localScale.x;
               
                if (x < 0)
                {
                    player1.localScale += new Vector3(-1, 1, 1);
                    CardSelect.clicked3 = false;
                }
                else if (x > 0)
                {
                    player1.localScale += new Vector3(1, 1, 1);
                    CardSelect.clicked3 = false;
                }
               
                float i = player1.localScale.y;
                float j = i * 16 / 100;
                groudIncrease = j;
                PlayerMovement.groundCheckRadius = groudIncrease;
                CardSelect.clicked3 = false;



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
