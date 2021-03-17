using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{


    public List<Customer> CustomersList = new List<Customer>();
    private Customer badguy;
    private PlayerController player;
    int currentCustomers = 0;
    public Customer[] customerPrefabs;
    [SerializeField]public int decoyRangeMax = 3;
    [SerializeField]public int decoyRangeMin = 1;
    [SerializeField] public int totalCustomers = 20;


    

    // Start is called before the first frame update
    void Start()
    {
        InitializeGame();

    }


    void InitializeGame()
    {

        //This methods shuffles the character prefab array so that we randomize the sprites of the characters
        reshuffle(customerPrefabs);

        // This function will create all of the games customers at random, it will also make a list with all of the customers, and it will make arrays of each trait type decoy.
        // We can use these arrays to help decide what clues are good/bad/really too good of a clue, by seeing how many decoys are in each array.
        // Create the Baddy at Complete Random, and add him to a Mast list of Customers.

        badguy = gameObject.AddComponent<Customer>() as Customer;
        badguy = customerPrefabs[currentCustomers];
        badguy.CreateCustomer();
        badguy.isKiller = true;
        CustomersList.Add(badguy);
        currentCustomers++;


        //Create at least one other person that shares the same trait for every trait, and also add them to the list.
        int favPizzaDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < favPizzaDecoys; i++)
        {
            Customer newCustomer = gameObject.AddComponent<Customer>() as Customer;
            newCustomer = customerPrefabs[currentCustomers];

                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
                newCustomer.favPizza = badguy.favPizza;
        
            while (
                newCustomer.favPizza == badguy.favPizza
                && newCustomer.favDrink == badguy.favDrink
                && newCustomer.favSideFood == badguy.favSideFood
                && newCustomer.mood == badguy.mood
                && newCustomer.howTip == badguy.howTip
                && newCustomer.hateDrink == badguy.hateDrink
                && newCustomer.hatePizza == badguy.hatePizza
                )
            {
                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
                newCustomer.favPizza = badguy.favPizza;
            }
            
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int favDrinkDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < favDrinkDecoys; i++)
        {
            Customer newCustomer = gameObject.AddComponent<Customer>() as Customer;
            newCustomer = customerPrefabs[currentCustomers];

            newCustomer.ClearCustomer();
            newCustomer.CreateCustomer();
            newCustomer.favDrink = badguy.favDrink;

            while (
                newCustomer.favPizza == badguy.favPizza
                && newCustomer.favDrink == badguy.favDrink
                && newCustomer.favSideFood == badguy.favSideFood
                && newCustomer.mood == badguy.mood
                && newCustomer.howTip == badguy.howTip
                && newCustomer.hateDrink == badguy.hateDrink
                && newCustomer.hatePizza == badguy.hatePizza
                )
            {
                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
                newCustomer.favDrink = badguy.favDrink;
            }
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int favSideDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < favSideDecoys; i++)
        {
            Customer newCustomer = gameObject.AddComponent<Customer>() as Customer;
            newCustomer = customerPrefabs[currentCustomers];

            newCustomer.ClearCustomer();
            newCustomer.CreateCustomer();
            newCustomer.favSideFood = badguy.favSideFood;

            while (
                newCustomer.favPizza == badguy.favPizza
                && newCustomer.favDrink == badguy.favDrink
                && newCustomer.favSideFood == badguy.favSideFood
                && newCustomer.mood == badguy.mood
                && newCustomer.howTip == badguy.howTip
                && newCustomer.hateDrink == badguy.hateDrink
                && newCustomer.hatePizza == badguy.hatePizza
                )
            {
                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
                newCustomer.favSideFood = badguy.favSideFood;
            }

            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int HatePizzaDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < HatePizzaDecoys; i++)
        {
            Customer newCustomer = gameObject.AddComponent<Customer>() as Customer;
            newCustomer = customerPrefabs[currentCustomers];

            newCustomer.ClearCustomer();
            newCustomer.CreateCustomer();
            newCustomer.hatePizza = badguy.hatePizza;
            
            while (
                newCustomer.favPizza == badguy.favPizza
                && newCustomer.favDrink == badguy.favDrink
                && newCustomer.favSideFood == badguy.favSideFood
                && newCustomer.mood == badguy.mood
                && newCustomer.howTip == badguy.howTip
                && newCustomer.hateDrink == badguy.hateDrink
                && newCustomer.hatePizza == badguy.hatePizza
                )
            {
                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
                newCustomer.hatePizza = badguy.hatePizza;
            }
            
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int HateDrinkDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < HateDrinkDecoys; i++)
        {
            Customer newCustomer = gameObject.AddComponent<Customer>() as Customer;
            newCustomer = customerPrefabs[currentCustomers];

            newCustomer.ClearCustomer();
            newCustomer.CreateCustomer();
            newCustomer.hateDrink = badguy.hateDrink;

            while (
                newCustomer.favPizza == badguy.favPizza
                && newCustomer.favDrink == badguy.favDrink
                && newCustomer.favSideFood == badguy.favSideFood
                && newCustomer.mood == badguy.mood
                && newCustomer.howTip == badguy.howTip
                && newCustomer.hateDrink == badguy.hateDrink
                && newCustomer.hatePizza == badguy.hatePizza
                )
            {
                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
                newCustomer.hateDrink = badguy.hateDrink;
            }

            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int HowTipDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < HowTipDecoys; i++)
        {
            Customer newCustomer = gameObject.AddComponent<Customer>() as Customer;
            newCustomer = customerPrefabs[currentCustomers];

            newCustomer.ClearCustomer();
            newCustomer.CreateCustomer();
            newCustomer.howTip = badguy.howTip;

            while (
                newCustomer.favPizza == badguy.favPizza
                && newCustomer.favDrink == badguy.favDrink
                && newCustomer.favSideFood == badguy.favSideFood
                && newCustomer.mood == badguy.mood
                && newCustomer.howTip == badguy.howTip
                && newCustomer.hateDrink == badguy.hateDrink
                && newCustomer.hatePizza == badguy.hatePizza
                )
            {
                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
                newCustomer.howTip = badguy.howTip;
            }

            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int MoodDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < MoodDecoys; i++)
        {
            Customer newCustomer = gameObject.AddComponent<Customer>() as Customer;
            newCustomer = customerPrefabs[currentCustomers];

            newCustomer.ClearCustomer();
            newCustomer.CreateCustomer();
            newCustomer.mood = badguy.mood;

            while (
               newCustomer.favPizza == badguy.favPizza
               && newCustomer.favDrink == badguy.favDrink
               && newCustomer.favSideFood == badguy.favSideFood
               && newCustomer.mood == badguy.mood
               && newCustomer.howTip == badguy.howTip
               && newCustomer.hateDrink == badguy.hateDrink
               && newCustomer.hatePizza == badguy.hatePizza
               )
            {
                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
                newCustomer.mood = badguy.mood;
            }

            CustomersList.Add(newCustomer);
            currentCustomers++;
        }


        // Figure out how many Customers are left to fill the roster and create that many at random. Then add them to the list.

        int customersRemaining = totalCustomers - currentCustomers;

        for (int i = 0; i < customersRemaining; i++)
        {
            Customer newCustomer = gameObject.AddComponent<Customer>() as Customer;
            newCustomer = customerPrefabs[currentCustomers];

            newCustomer.ClearCustomer();
            newCustomer.CreateCustomer();
            CustomersList.Add(newCustomer);

            while (
               newCustomer.favPizza == badguy.favPizza
               && newCustomer.favDrink == badguy.favDrink
               && newCustomer.favSideFood == badguy.favSideFood
               && newCustomer.mood == badguy.mood
               && newCustomer.howTip == badguy.howTip
               && newCustomer.hateDrink == badguy.hateDrink
               && newCustomer.hatePizza == badguy.hatePizza
               )
            {
                newCustomer.ClearCustomer();
                newCustomer.CreateCustomer();
            }

            currentCustomers++;

        }

        for(int i = 0; i < CustomersList.Count; i++)
        {
            Debug.Log("Customer " + i);
            CustomersList[i].PrintCustomer();
        }
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void reshuffle(Customer[] customers)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < customers.Length; t++)
        {
            Customer tmp = customers[t];
            int r = Random.Range(t, customers.Length);
            customers[t] = customers[r];
            customers[r] = tmp;
        }
    }



}
