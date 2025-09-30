using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CardSelect : MonoBehaviour
{
   

  
    public int randomNumber;
    public bool clicked;
    public bool clicked2;
    public bool clicked3;
    public bool p2;
    public Firing firing;
    public FiringController controller;
    
    
    void Start()
    {

        randomNumber = Random.Range(0, 20);

    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != "Cards")
        {
            randomNumber = Random.Range(1, 20);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            clicked = true;
            Debug.Log(randomNumber);
            SceneManager.LoadScene(1);
            firing.enabled = true;
            controller.enabled = true;
        }

else if (collision.gameObject.CompareTag("Projectile2"))
            {
                
                Debug.Log(randomNumber);
            p2 = true;
            SceneManager.LoadScene(1);
            firing.enabled = true;
            controller.enabled = true;
        }
        }
    }

