using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CardSelect : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public int randomNumber1;
    public int randomNumber;
    public int randomNumber2;
    public bool clicked;
    
    void Start()
    {
        randomNumber = Random.Range(1, 20);
        randomNumber1 = Random.Range(1, 20);
        randomNumber2 = Random.Range(1, 20);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        if (button1)
        {
            
            Debug.Log(randomNumber);
           
        }
        SceneManager.LoadScene(0);
       clicked = true;
    }
    public void OnClick2()
    {
        if (button2)
        {
           
            Debug.Log(randomNumber1);
          
        }
        SceneManager.LoadScene(0);
        clicked = true;
    }
    public void OnClick3()
    {
        if (button3)
        {
           
            Debug.Log(randomNumber2);
        }
        SceneManager.LoadScene(0);
        clicked = true;
    }
}
