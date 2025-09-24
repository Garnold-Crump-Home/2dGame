using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CardSelect1 : MonoBehaviour
{
   

    public int randomNumber1;
    
    
    public bool clicked2;
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
        if (currentScene.name == "SampleScene")
        {
            randomNumber1 = Random.Range(0, 20);
            Debug.Log("Random number");
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            clicked2 = true;
            Debug.Log(randomNumber1);
            SceneManager.LoadScene(1);
            firing.enabled = true;
            controller.enabled = true;
        }

else if (collision.gameObject.CompareTag("Projectile2"))
            {
                
                Debug.Log(randomNumber1);
            p2 = true;
            SceneManager.LoadScene(1);
            firing.enabled = true;
            controller.enabled = true;
        }
        }
    }

