
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
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
    public Player2Controller Player2Controller;
    public Canvas canvas;
    public Transform player1;
    public Transform player2;
    public GameObject colliders;
    public GameObject colliders2;
    public GameObject colliders3;
    public CardSelect1 CardSelect1;
    public CardSelect2 CardSelect2;
    public int card1;
    public int card2; 
    public int card3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        int card1 = CardSelect.randomNumber;
        int card2 = CardSelect1.randomNumber1;
        int card3 = CardSelect2.randomNumber2;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Cards") { canvas.enabled = true; b1.enabled = true; b2.enabled = true; b3.enabled = true; colliders.SetActive(true); colliders2.SetActive(true); colliders3.SetActive(true); }
        if (sceneName != "Cards") { canvas.enabled = false; b1.enabled = false; b2.enabled = false; b3.enabled = false; colliders.SetActive(false); colliders2.SetActive(false); colliders3.SetActive(false); }

        if (card1 == 1)
        {
            b1.image.sprite = Card1;
        }

            if (card1 == 2 || card2 == 2 || card3 == 2)
        {
            b1.image.sprite = Card2;
             b2.image.sprite = Card2;
            b3.image.sprite = Card2;
        }
            //start of huge card
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
                float groudIncrease = j;

                PlayerMovement.groundCheckRadius = groudIncrease;
                CardSelect.clicked = false;




            }
            else if (CardSelect.p2)
            {
                int health = Player2Controller.playerMaxHealth * 4;
                int h = health / 10;
                h += Player2Controller.playerMaxHealth;
                Player2Controller.playerMaxHealth = h;
                Player2Controller.playerHealth = Player2Controller.playerMaxHealth;
                float speed = Player2Controller.moveSpeed * 25;
                float speed1 = speed / 100;
                Player2Controller.moveSpeed -= speed1;
                float x = player2.localScale.x;

                if (x < 0)
                {
                    player2.localScale += new Vector3(-1, 1, 1);
                    CardSelect.p2 = false;
                }
                else if (x > 0)
                {
                    player2.localScale += new Vector3(1, 1, 1);
                    CardSelect.p2 = false;
                }

                float i = player2.localScale.y;
                float j = i * 16 / 100;
                float groudIncrease = j;

                Player2Controller.groundCheckRadius = groudIncrease;
                CardSelect.p2 = false;
            }
        }

        else if (CardSelect1.randomNumber1 == 1)
        {

            b2.image.sprite = Card1;

            if (CardSelect1.clicked2)
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
                    CardSelect1.clicked2 = false;
                }
                else if (x > 0)
                {
                    player1.localScale += new Vector3(1, 1, 1);
                    CardSelect1.clicked2 = false;
                }

                float i = player1.localScale.y;
                float j = i * 16 / 100;
                float groudIncrease = j;

                PlayerMovement.groundCheckRadius = groudIncrease;
                CardSelect1.clicked2 = false;




            }
            else if (CardSelect1.p2)
            {
                int health = Player2Controller.playerMaxHealth * 4;
                int h = health / 10;
                h += Player2Controller.playerMaxHealth;
                Player2Controller.playerMaxHealth = h;
                Player2Controller.playerHealth = Player2Controller.playerMaxHealth;
                float speed = Player2Controller.moveSpeed * 25;
                float speed1 = speed / 100;
                Player2Controller.moveSpeed -= speed1;
                float x = player2.localScale.x;

                if (x < 0)
                {
                    player2.localScale += new Vector3(-1, 1, 1);
                    CardSelect1.p2 = false;
                }
                else if (x > 0)
                {
                    player2.localScale += new Vector3(1, 1, 1);
                    CardSelect1.p2 = false;
                }

                float i = player2.localScale.y;
                float j = i * 16 / 100;
                float groudIncrease = j;

                Player2Controller.groundCheckRadius = groudIncrease;
                CardSelect1.clicked2 = false;
            }
        }
        else if (CardSelect2.randomNumber2 == 1)
        {

            b3.image.sprite = Card1;
            if (CardSelect2.clicked3)
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
                    CardSelect2.clicked3 = false;
                }
                else if (x > 0)
                {
                    player1.localScale += new Vector3(1, 1, 1);
                    CardSelect2.clicked3 = false;
                }

                float i = player1.localScale.y;
                float j = i * 16 / 100;
                float groudIncrease = j;
                PlayerMovement.groundCheckRadius = groudIncrease;
                CardSelect2.clicked3 = false;



            }
            else if (CardSelect2.p2)
            {
                int health = Player2Controller.playerMaxHealth * 4;
                int h = health / 10;
                h += Player2Controller.playerMaxHealth;
                Player2Controller.playerMaxHealth = h;
                Player2Controller.playerHealth = Player2Controller.playerMaxHealth;
                float speed = Player2Controller.moveSpeed * 25;
                float speed1 = speed / 100;
                Player2Controller.moveSpeed -= speed1;
                float x = player2.localScale.x;

                if (x < 0)
                {
                    player2.localScale += new Vector3(-1, 1, 1);
                    CardSelect2.p2 = false;
                }
                else if (x > 0)
                {
                    player2.localScale += new Vector3(1, 1, 1);
                    CardSelect2.p2 = false;
                }

                float i = player2.localScale.y;
                float j = i * 16 / 100;
                float groudIncrease = j;

                Player2Controller.groundCheckRadius = groudIncrease;
                CardSelect2.p2 = false;
            }
        }
        //end of huge card
    }
    
}
