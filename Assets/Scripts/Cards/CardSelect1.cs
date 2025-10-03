using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CardSelect1 : MonoBehaviour
{
    public int randomMapLoader;
    public bool random;
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
        randomMapLoader = Random.Range(2, 10);
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != "Cards")
        {
            randomNumber1 = Random.Range(1, 20);
            randomMapLoader = Random.Range(2, 7);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            clicked2 = true;
            Debug.Log(randomNumber1);
            SceneManager.LoadScene(randomMapLoader);
            firing.enabled = true;
            controller.enabled = true;
        }

        else if (collision.gameObject.CompareTag("Projectile2"))
        {

            Debug.Log(randomNumber1);

            p2 = true;
            SceneManager.LoadScene(randomMapLoader);
            firing.enabled = true;
            controller.enabled = true;
        }
    }
}

