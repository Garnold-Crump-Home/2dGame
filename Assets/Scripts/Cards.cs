
using Unity.VisualScripting;
using Unity.VisualScripting.ReorderableList;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Cards : MonoBehaviour
{
    public playerDamage playerDamage;
    public Player2Damage player2Damage;
    public CardSelect CardSelect;
    public Button b1;
    public Button b2;
    public Button b3;
    public Sprite Card1;
    public Sprite Card2;
    public Sprite Speed_Card;
    public Sprite Glass_Cannon_Card;
    public Sprite Homing_Card;
    public Sprite BlankCard;
    public PlayerMovement PlayerMovement;
    public Player2Controller Player2Controller;
    public Canvas canvas;
    public Transform player1;
    public Transform player2;
    public Collider2D colliders;
    public Collider2D colliders2;
    public Collider2D colliders3;
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


        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Cards")
        {
            canvas.enabled = true; b1.enabled = true; b2.enabled = true; b3.enabled = true; colliders.enabled = true; colliders2.enabled = true; colliders3.enabled = true;
        }
        if (sceneName != "Cards")
        {
            canvas.enabled = false; b1.enabled = false; b2.enabled = false; b3.enabled = false; colliders.enabled = false; colliders2.enabled = false; colliders3.enabled = false;
        }

        if (sceneName == "Cards")
        {
            int card1 = CardSelect.randomNumber;
            int card2 = CardSelect1.randomNumber1;
            int card3 = CardSelect2.randomNumber2;
            if (card1 != 1 || card1 != 2 || card1 != 3)
            {
                b1.image.sprite = BlankCard;
            }
            if (card2 != 1 || card2 != 2 || card2 != 3)
            {
                b2.image.sprite = BlankCard;
            }
            if (card3 != 1 || card3 != 2 || card3 != 3)
            {
                b3.image.sprite = BlankCard;
            }



            //start of huge card
            if (card1 == 1)
            {

                b1.image.sprite = Card1;

                if (CardSelect.clicked && card1 == 1)
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

            else if (card2 == 1)
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
            else if (card3 == 1)
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
            //start of projectile size
            if (card1 == 2)
            {
                b1.image.sprite = Card2;
                if (CardSelect.clicked)
                {
                    PlayerMovement.IncreaseSize = true;
                    CardSelect.clicked = false;
                }
                else if (CardSelect.p2)
                {
                    Player2Controller.IncreaseSize = true;
                    CardSelect2.p2 = false;

                }
            }
            if (card2 == 2)
            {
                b2.image.sprite = Card2;
                if (CardSelect1.clicked2)
                {
                    PlayerMovement.IncreaseSize = true;
                    CardSelect1.clicked2 = false;
                }
                else if (CardSelect2.p2)
                {
                    Player2Controller.IncreaseSize = true;
                    CardSelect2.p2 = false;
                }

            }
            if (card3 == 2)
            {
                b3.image.sprite = Card2;
                if (CardSelect2.clicked3)
                {
                    PlayerMovement.IncreaseSize = true;
                    CardSelect2.clicked3 = false;
                }
                else if (CardSelect2.p2)
                {
                    Player2Controller.IncreaseSize = true;
                    CardSelect2.p2 = false;
                }
            }
            //end of projectile size
            //start of speed card
            if (card1 == 3)
            {
                b1.image.sprite = Speed_Card;
                if (CardSelect.clicked)
                {
                    float x = PlayerMovement.moveSpeed * 0.3f;
                    PlayerMovement.moveSpeed += x;
                    float a = player1.localScale.x;

                    if (a < 0)
                    {
                        player1.localScale -= new Vector3(-1, 1, 1);
                        CardSelect.clicked = false;
                    }
                    else if (a > 0)
                    {
                        player1.localScale -= new Vector3(1, 1, 1);
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
                    float y = Player2Controller.moveSpeed * 0.3f;
                    Player2Controller.moveSpeed += y;
                    float c = player1.localScale.x;

                    if (c < 0)
                    {
                        player2.localScale -= new Vector3(-1, 1, 1);
                        CardSelect.p2 = false;
                    }
                    else if (c > 0)
                    {
                        player2.localScale -= new Vector3(1, 1, 1);
                        CardSelect.p2 = false;
                    }

                    float b = player2.localScale.y;
                    float v = b * 16 / 100;
                    float groudIncrease1 = v;
                    Player2Controller.groundCheckRadius = groudIncrease1;
                    CardSelect.p2 = false;
                }
            }
            if (card2 == 3)
            {
                b2.image.sprite = Speed_Card;
                if (CardSelect1.clicked2)
                {
                    float x = PlayerMovement.moveSpeed * 0.3f;
                    PlayerMovement.moveSpeed += x;
                    float a = player1.localScale.x;

                    if (a < 0)
                    {
                        player1.localScale -= new Vector3(-1, 1, 1);
                        CardSelect1.clicked2 = false;
                    }
                    else if (a > 0)
                    {
                        player1.localScale -= new Vector3(1, 1, 1);
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
                    float y = Player2Controller.moveSpeed * 0.3f;
                    Player2Controller.moveSpeed += y;
                    float c = player1.localScale.x;

                    if (c < 0)
                    {
                        player2.localScale -= new Vector3(-1, 1, 1);
                        CardSelect1.p2 = false;
                    }
                    else if (c > 0)
                    {
                        player2.localScale -= new Vector3(1, 1, 1);
                        CardSelect1.p2 = false;
                    }

                    float b = player2.localScale.y;
                    float v = b * 16 / 100;
                    float groudIncrease1 = v;
                    Player2Controller.groundCheckRadius = groudIncrease1;
                    CardSelect1.p2 = false;
                }
            }
            if (card3 == 3)
            {
                b3.image.sprite = Speed_Card;
                if (CardSelect2.clicked3)
                {
                    float x = PlayerMovement.moveSpeed * 0.3f;
                    PlayerMovement.moveSpeed += x;
                    float a = player1.localScale.x;

                    if (a < 0)
                    {
                        player1.localScale -= new Vector3(-1, 1, 1);
                        CardSelect2.clicked3 = false;
                    }
                    else if (a > 0)
                    {
                        player1.localScale -= new Vector3(1, 1, 1);
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
                    float y = Player2Controller.moveSpeed * 0.3f;
                    Player2Controller.moveSpeed += y;
                    float c = player1.localScale.x;

                    if (c < 0)
                    {
                        player2.localScale -= new Vector3(-1, 1, 1);
                        CardSelect2.p2 = false;
                    }
                    else if (c > 0)
                    {
                        player2.localScale -= new Vector3(1, 1, 1);
                        CardSelect2.p2 = false;
                    }

                    float b = player2.localScale.y;
                    float v = b * 16 / 100;
                    float groudIncrease1 = v;
                    Player2Controller.groundCheckRadius = groudIncrease1;
                    CardSelect2.p2 = false;
                }
            } //end of speed card

            //start of glass cannon

            if (card1 == 4)
            {
                b1.image.sprite = Glass_Cannon_Card;
                if (CardSelect.clicked)
                {
                    int f = PlayerMovement.playerMaxHealth * 80 / 100;
                    PlayerMovement.playerMaxHealth -= f;
                    PlayerMovement.playerHealth = PlayerMovement.playerMaxHealth;
                    int z = PlayerMovement.player1DamageAmount * 95 / 100;
                    PlayerMovement.player1DamageAmount += z * 2;
                    CardSelect.clicked = false;

                }
                if (CardSelect.p2)
                {
                    int f = Player2Controller.playerMaxHealth * 80 / 100;
                    Player2Controller.playerMaxHealth -= f;
                    Player2Controller.playerHealth = Player2Controller.playerMaxHealth;
                    int z = Player2Controller.player2Damage * 95 / 100;
                    Player2Controller.player2Damage += z * 2;
                    CardSelect.p2 = false;
                }
            }
            if (card2 == 4)
            {
                b2.image.sprite = Glass_Cannon_Card;
                if (CardSelect1.clicked2)
                {
                    int f = PlayerMovement.playerMaxHealth * 80 / 100;
                    PlayerMovement.playerMaxHealth -= f;
                    PlayerMovement.playerHealth = PlayerMovement.playerMaxHealth;
                    int z = PlayerMovement.player1DamageAmount * 95 / 100;
                    PlayerMovement.player1DamageAmount += z * 2;
                    CardSelect1.clicked2 = false;

                }
                if (CardSelect1.p2)
                {
                    int f = Player2Controller.playerMaxHealth * 80 / 100;
                    Player2Controller.playerMaxHealth -= f;
                    Player2Controller.playerHealth = Player2Controller.playerMaxHealth;
                    int z = Player2Controller.player2Damage * 95 / 100;
                    Player2Controller.player2Damage += z * 2;
                    CardSelect1.p2 = false;
                }
            }
            if (card3 == 4)
            {
                b3.image.sprite = Glass_Cannon_Card;
                if (CardSelect2.clicked3)
                {
                    int f = PlayerMovement.playerMaxHealth * 80 / 100;
                    PlayerMovement.playerMaxHealth -= f;
                    PlayerMovement.playerHealth = PlayerMovement.playerMaxHealth;
                    int z = PlayerMovement.player1DamageAmount * 95 / 100;
                    PlayerMovement.player1DamageAmount += z * 2;
                    CardSelect2.clicked3 = false;

                }
                if (CardSelect2.p2)
                {
                    int f = Player2Controller.playerMaxHealth * 80 / 100;
                    Player2Controller.playerMaxHealth -= f;
                    Player2Controller.playerHealth = Player2Controller.playerMaxHealth;
                    int z = Player2Controller.player2Damage * 95 / 100;
                    Player2Controller.player2Damage += z * 2;
                    CardSelect2.p2 = false;
                }
            } //End of glass cannon
            //Start of Homing
            if (card1 == 5)
            {
                b3.image.sprite = Homing_Card;
                if (CardSelect.clicked)
                {
                   int l = PlayerMovement.player1DamageAmount * 25 / 100;
                    PlayerMovement.player1DamageAmount -= l;
                    playerDamage.Homing = true;
                    CardSelect.clicked = false;
                }
                if (CardSelect.p2)
                {
                    {
                        int k = Player2Controller.player2Damage * 25 / 100;
                        Player2Controller.player2Damage -= k;
                        player2Damage.Homing = true;
                        CardSelect.p2 = false;
                    }

                }

            }
            if (card2 == 5)
            {
                b3.image.sprite = Homing_Card;
                if (CardSelect1.clicked2)
                {
                    int l = PlayerMovement.player1DamageAmount * 25 / 100;
                    PlayerMovement.player1DamageAmount -= l;
                    playerDamage.Homing = true;
                    CardSelect1.clicked2 = false;
                }
                if (CardSelect.p2)
                {
                    {
                        int k = Player2Controller.player2Damage * 25 / 100;
                        Player2Controller.player2Damage -= k;
                        player2Damage.Homing = true;
                        CardSelect1.p2 = false;
                    }

                }

            }
            if (card3 == 5)
            {
                b3.image.sprite = Homing_Card;
                if (CardSelect2.clicked3)
                {
                    int l = PlayerMovement.player1DamageAmount * 25 / 100;
                    PlayerMovement.player1DamageAmount -= l;
                    playerDamage.Homing = true;
                    CardSelect2.clicked3 = false;
                }
                if (CardSelect2.p2)
                {
                    {
                        int k = Player2Controller.player2Damage * 25 / 100;
                        Player2Controller.player2Damage -= k;
                        player2Damage.Homing = true;
                        CardSelect2.p2 = false;
                    }

                }

            } //End of Homing
        }
    }
}


