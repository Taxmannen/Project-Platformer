using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaAIScript : MonoBehaviour
{

    Vector2 distance;
    public Transform player;
    public Transform weaponHold;
    public GameObject weapon;
    private Vector2 movementDirection;


    // Use this for initialization
    void Start()
    {
        weapon.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(transform.position, player.position);
        if (distance < 10f)
        {
            weapon.SetActive(true);
            Debug.Log("Close!");
            
        }
        else
            weapon.SetActive(false);



    }

    private void beginSantaAttack()
    {

        Debug.Log("lol");
    }

    void weaponMove()
    {
       
    }
}
