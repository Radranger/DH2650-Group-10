using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class PizzaHealth : MonoBehaviour
{
    public int pizzas;
    public int maxpizzas;

    public Sprite emptyPizza;
    public Sprite fullPizza;
    public Image[] pizzaStack;
    private bool hasCollided = false; // Flag to track if collision has occurred

    public PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < pizzaStack.Length; i++)
        {

            if (i < pizzas)
            {
                pizzaStack[i].sprite = fullPizza;
            }
            else
            {
                pizzaStack[i].sprite = emptyPizza;
            }

            if (i < maxpizzas)
            {
                pizzaStack[i].enabled = true;
            }
            else
            {
                pizzaStack[i].enabled = false;

            }
        }

    }

    public void TakeDamage(int amount)
    {
        if (hasCollided)
            return;

        pizzas -= amount;

        if (pizzas <= 0)
        {
            playerMovement.enabled = false;
        }
        hasCollided = true;

    }


}