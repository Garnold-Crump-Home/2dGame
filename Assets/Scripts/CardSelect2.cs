using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CardSelect2 : MonoBehaviour
{

    public bool random;
    public int randomNumber2;
    public bool clicked3;
    public bool p2;
    public Firing firing;
    public FiringController controller;


    void Start()
    {
    
        

    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != "Cards")
        {
            randomNumber2 = Random.Range(0, 20);
            
        }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            clicked3 = true;
            Debug.Log(randomNumber2);
            SceneManager.LoadScene(1);
            firing.enabled = true;
            controller.enabled = true;
        }

else if (collision.gameObject.CompareTag("Projectile2"))
            {
                
                Debug.Log(randomNumber2);
            
            p2 = true;
            SceneManager.LoadScene(1);
            firing.enabled = true;
            controller.enabled = true;
        }
        }
    }

