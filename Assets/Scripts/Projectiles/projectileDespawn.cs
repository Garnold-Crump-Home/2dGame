using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class projectileDespawn : MonoBehaviour
{
   
    public int bounces = 0;

    public PhysicsMaterial2D material;
    public int bounciness = 3;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (bounces == 0)
        {
            Debug.Log("works");
            Destroy(this.gameObject);
            material.bounciness = 0;
        }
        if(bounces >= 1)
        {
            material.bounciness = bounciness;
            bounces -= 1 ;
        }
    }
}
