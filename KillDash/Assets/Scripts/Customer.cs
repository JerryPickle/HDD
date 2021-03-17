using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    int[] waitTimes = { 55, 45, 35 };
    enum Tips {Extra, Normal, None}
    enum Drinks {Coke, Juice, Milkshake, Orange_Juice, Garlic_Juice}
    enum Pizza {Cheese, Pepperoni, Pineapple, Meat_Lovers, The_Garlic_Special}
    enum SideFood {Fries, Tots, Chips, Breadsticks, The_Garlic_Surprise}

    public int mood = -1;
    public string howTip = "-1";
    public string favDrink = "-1";
    public string favPizza = "-1";
    public string favSideFood = "-1";
    public string hatePizza = "-1";
    public string hateDrink = "-1";
    public bool isKiller = false;
    public FoodOrder myOrder;
    [SerializeField]SpriteRenderer thisSprite;




    public void CreateCustomer()
    {
        myOrder = GetComponent<FoodOrder>();

        //Randomly Generate Attributes
        if(mood == -1)
        {
            mood = waitTimes[Random.Range(0, 2)];
        }

       
        if(howTip.Equals("-1"))
        {
            howTip = ((Tips)Random.Range(0, 2)).ToString("g");
        }
        

        if (favDrink.Equals("-1"))
        {
            if(hateDrink.Equals("-1"))
            {
                favDrink = ((Drinks)Random.Range(0, 4)).ToString("g");
            }
            else
            {
                favDrink = hateDrink;
            }
            while(favDrink.Equals(hateDrink))
            {
                favDrink = ((Drinks)Random.Range(0,4)).ToString("g");
            }
        }
           

        if(favPizza.Equals("-1"))
        {
            if (hatePizza.Equals("-1"))
            {
                favPizza = ((Pizza)Random.Range(0, 4)).ToString("g");
            }
            else
            {
                favPizza = hatePizza;
            }
            while (favPizza.Equals(hatePizza))
            {
                favPizza = ((Pizza)Random.Range(0, 4)).ToString("g");
            }
            
        }
        

        if(favSideFood.Equals("-1"))
        {
            favSideFood = ((SideFood)Random.Range(0, 4)).ToString("g");
        }


       if (hatePizza.Equals("-1"))
        {
            if (favPizza.Equals("-1"))
            {
                hatePizza = ((Pizza)Random.Range(0, 4)).ToString("g");
            }
            else
            {
                hatePizza = favPizza;
            }
            while (hatePizza.Equals(favPizza))
            {
                hatePizza = ((Pizza)Random.Range(0,4)).ToString("g");
            }
            

        }
        
       if (hateDrink.Equals("-1"))
        {
            if (favDrink.Equals("-1"))
            {
                hateDrink = ((Drinks)Random.Range(0, 4)).ToString("g");
            }
            else
            {
                hateDrink = favDrink;
            }
            while (hateDrink.Equals(favDrink))
            {
                hateDrink = ((Drinks)Random.Range(0, 4)).ToString("g");
            }
        }

        CreateOrder();

    }

    //Creates an order object with the customers favorite pizza, drink, and sidefood
    private void CreateOrder()
    {

        myOrder.CreateOrder(favPizza,favDrink,favSideFood);

    }

    public void PrintCustomer()
    {
        Debug.Log("IsKiller: " + isKiller);
        Debug.Log("Mood = " + mood);
        Debug.Log("How Tip = " + howTip);
        Debug.Log("favDrink = " + favDrink);
        Debug.Log("favPizza = " + favPizza);
        Debug.Log("favSideFood = " + favSideFood);
        Debug.Log("hatePizza = " + hatePizza);
        Debug.Log("hateDrink = " + hateDrink);

    }

    public bool equals(Customer customer2)
    {

        if (this.favDrink == customer2.favDrink)
        {

        }

    }



    // Start is called before the first frame update
    void Start()
    {
        //CreateCustomer(); //This is used for testing
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
