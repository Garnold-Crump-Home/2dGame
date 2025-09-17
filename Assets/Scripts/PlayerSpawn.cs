using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private GameObject p1;
    private GameObject p2;
    public Transform spawn1;
    public Transform spawn2;
    
    void Start()
    {
        p1 = GameObject.FindGameObjectWithTag("Player1");
        p2 = GameObject.FindGameObjectWithTag("Player2");

        if (p1 != null && spawn1 != null)
        {
            p1.transform.position = spawn1.position;
        }

        if (p2 != null && spawn2 != null)
        {
            p2.transform.position = spawn2.position;
        }
    }
}