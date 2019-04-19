using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public bool isInItem;
    CookingItem thingImIn = null;
    public bool isReady;

    public int cookHeat;        //0=green, 1=yellow, 2=orange, 3=red, 4=n/a
    public float cookTime;      //-1 = n/a
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isInItem && isReady) GetComponentInParent<FinalFood>().ingredients.Add(this);
        else GetComponentInParent<FinalFood>().ingredients.Remove(this);

        if (isInItem)
        {
            //PSA: this sucks rn, fix it at some point
            Vector3 pos = thingImIn.transform.position;
            pos.y += 0.5f;
            this.transform.position = pos;
        }
    }

    private void OnCollisionStay(Collision c)
    {
        if (c.gameObject.GetComponent<CookingItem>() != null)
        {
            if (!isInItem)
            {
                isInItem = true;
                thingImIn = c.gameObject.GetComponent<CookingItem>();
            }
        }
        else
        {
            return;
        }
    }
}
