using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingItem : MonoBehaviour
{
    public enum Purpose {Prep, Cooks, Stove, Oven};
    public Purpose purpose;

    List<Ingredient> thingsInMe = new List<Ingredient>();
    public bool isFull;
    // Start is called before the first frame update
    void Start()

    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
