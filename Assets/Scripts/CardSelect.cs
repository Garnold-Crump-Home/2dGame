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
    public bool clicked2;
    public bool clicked3;
    
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
        clicked = true;
        if (button1)
        {
            
            Debug.Log(randomNumber);
            SceneManager.LoadScene(1);
        }
       
       
      
    }
    public void OnClick2()
    {
        clicked2 = true;
        if (button2)
        {
           
            Debug.Log(randomNumber1);
            SceneManager.LoadScene(1);

        }
       
        
       
    }
    public void OnClick3()
    {
        clicked3 = true;
        if (button3)
        {
           
            Debug.Log(randomNumber2); SceneManager.LoadScene(1);
        }
       
       
        
    }
}
