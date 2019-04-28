using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.EventSystems;

public class RecipeMenuController : MonoBehaviour
{
    int omletteNum = 1;
    int chickenNum = 1;
    int cakeNum = 1;

    public Text recipeText;



    // Start is called before the first frame update
    void Start()
    {
        omletteNum = 1;
        chickenNum = 1;
        cakeNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClickedOmeletteNext()
    {
        if (omletteNum == 1)
            recipeText.text = "2. Add milk, and break the yolks, and stir until an even consistency is reached.";
        else if (omletteNum == 2)
            recipeText.text = "3. Add any seasonings, salt, pepper, and stir.";
        else if (omletteNum == 3)
            recipeText.text = "4. Pour mixture into a hot pan on Yellow heat.";
        else if (omletteNum == 4)
            recipeText.text = "5. Slowly add in prepared ingredients and allow to cook completely on one side.";
        else if (omletteNum == 5)
            recipeText.text = "6. FLIP the pan, and allow the omlette to cook completely";
        else
            recipeText.text = "7. Fold and serve the omlette to Steve. :)";

        if(omletteNum < 7)
            omletteNum ++;
    }

    public void buttonClickedOmelettePrevious()
    {
        if(omletteNum > 1)
            omletteNum--;

        if (omletteNum == 6)
            recipeText.text = "6. FLIP the pan, and allow the omlette to cook completely";
        else if (omletteNum == 5)
            recipeText.text = "5. Slowly add in prepared ingredients and allow to cook completely on one side.";
        else if (omletteNum == 4)
            recipeText.text = "4. Pour mixture into a hot pan on Yellow heat.";
        else if (omletteNum == 3)
            recipeText.text = "3. Add any seasonings, salt, pepper, and stir.";
        else if (omletteNum == 2)
            recipeText.text = "2. Add milk, and break the yolks, and stir unitl an even consistency is reached.";
        else
            recipeText.text = "1. Crack 2 eggs into the mixing bowl.";
                
    }


    public void buttonClickedChickenNext()
    {
        if (chickenNum == 1)
            recipeText.text = "2. Place chicken breasts in freezer bags and and pound with the mallot.";
        else if (chickenNum == 2)
            recipeText.text = "3. Beat eggs in bowl.";
        else if (chickenNum == 3)
            recipeText.text = "4. Mix bread crumbs and 1/2 cup parmesan cheese in bowl(1) and set aside.";
        else if (chickenNum == 4)
            recipeText.text = "5. Sprinkle flour over the chicken breasts on both sides, coating completely.";
        else if (chickenNum == 5)
            recipeText.text = "6. Dip the chicken breasts in the the beaten eggs";
        else if (chickenNum == 6)
            recipeText.text = "7. Dip the chicken breasts in the bread crumb mixture.";
        else if (chickenNum == 7)
            recipeText.text = "8. Repeat for each chicken breast half, and set aside.";
        else if (chickenNum == 8)
            recipeText.text = "9. Heat 1 cup of oil in a learge skillet on 153 Orange heat.";
        else if (chickenNum == 9)
            recipeText.text = "10. Cook chicken for 2 minutes (2s on stove timer).";
        else if (chickenNum == 10)
            recipeText.text = "11. Place chicken on baking dish, top with tomato sauce, fresh mozz, basil, provolone, parmesan and drizzle with olive oil.";
        else if (chickenNum == 11)
            recipeText.text = "12. Bake in preheated oven for 20 minutes (20s).";
        else
            recipeText.text = "13. Plate, and serve to Steve! :)";

        if (chickenNum < 13)
            chickenNum++;
    }

    public void buttonClickedChickenPrevious()
    {
        if (chickenNum > 1)
            chickenNum--;

        if (chickenNum == 12)
            recipeText.text = "12. Bake in preheated oven for 20 minutes (20s).";
        else if (chickenNum == 11)
            recipeText.text = "11. Place chicken on baking dish, top with tomato sauce, fresh mozz, basil, provolone, parmesan and drizzle with olive oil.";
        else if (chickenNum == 10)
            recipeText.text = "10. Cook chicken for 2 minutes (2s on stove timer).";
        else if (chickenNum == 9)
            recipeText.text = "9. Heat 1 cup of oil in a learge skillet on 153 Orange heat.";
        else if (chickenNum == 8)
            recipeText.text = "8. Repeat for each chicken breast half, and set aside.";
        else if (chickenNum == 7)
            recipeText.text = "7. Dip the chicken breasts in the bread crumb mixture.";
        else if (chickenNum == 6)
            recipeText.text = "6. Dip the chicken breasts in the the beaten eggs";
        else if (chickenNum == 5)
            recipeText.text = "5. Sprinkle flour over the chicken breasts on both sides, coating completely.";
        else if (chickenNum == 4)
            recipeText.text = "4. Mix bread crumbs and 1/2 cup parmesan cheese in bowl(1) and set aside.";
        else if (chickenNum == 3)
            recipeText.text = "3. Beat eggs in bowl.";
        else if (chickenNum == 2)
            recipeText.text = "2. Place chicken breasts in freezer bags and and pound with the mallot.";
        else
            recipeText.text = "1. Preheat oven to Orange.";
    }

    public void buttonClickedCakeNext()
    {
        if (cakeNum == 1)
            recipeText.text = "2. Spray and flour cake pan.";
        else if (cakeNum == 2)
            recipeText.text = "3. Put eggs sugar, salt, and lemon zest in stand mixer.";
        else if (cakeNum == 3)
            recipeText.text = "4. Mix for 15 minutes (15s).";
        else if (cakeNum == 4)
            recipeText.text = "5. Add flour to mixture and mix with a wooden spoon.";
        else if (cakeNum == 5)
            recipeText.text = "6. Pour batter into prepared cake pan and bake for 40 minutes (40s).";
        else if (cakeNum == 6)
            recipeText.text = "7. While cake is cooking, mix heavy whipping cream, powdered sugar, and vanilla for 10 minutes (10s).";
        else if (cakeNum == 7)
            recipeText.text = "8. Transfer whipped cream to piping bag.";
        else if (cakeNum == 8)
            recipeText.text = "9. Take cake out of oven and let cool for 10 minutes (10s).";
        else if (cakeNum == 9)
            recipeText.text = "10. Cut cake in half with serrated knife.";
        else if (cakeNum == 10)
            recipeText.text = "11. Top first half with enough whipped cream to cover it completely.";
        else if (cakeNum == 11)
            recipeText.text = "12. Stack the the second half on top and repeat.";
        else if (cakeNum == 12)
            recipeText.text = "13. Cover the sides with whipped cream.";
        else
            recipeText.text = "14. Garnish with extra lemon zest and serve to Steve! :D";

        if (cakeNum < 14)
            cakeNum++;
    }

    public void buttonClickedCakePrevious()
    {
        if (cakeNum > 1)
            cakeNum--;

        if (cakeNum == 13)
            recipeText.text = "13. Cover the sides with whipped cream.";
        else if (cakeNum == 12)
            recipeText.text = "12. Stack the the second half on top and repeat.";
        else if (cakeNum == 11)
            recipeText.text = "11. Top first half with enough whipped cream to cover it completely.";
        else if (cakeNum == 10)
            recipeText.text = "10. Cut cake in half with serrated knife.";
        else if (cakeNum == 9)
            recipeText.text = "9. Take cake out of oven and let cool for 10 minutes (10s).";
        else if (cakeNum == 8)
            recipeText.text = "8. Transfer whipped cream to piping bag.";
        else if (cakeNum == 7)
            recipeText.text = "7. While cake is cooking, mix heavy whipping cream, powdered sugar, and vanilla for 10 minutes (10s).";
        else if (cakeNum == 6)
            recipeText.text = "6. Pour batter into prepared cake pan and bake for 40 minutes (40s).";
        else if (cakeNum == 5)
            recipeText.text = "5. Add flour to mixture and mix with a wooden spoon.";
        else if (cakeNum == 4)
            recipeText.text = "4. Mix for 15 minutes (15s).";
        else if (cakeNum == 3)
            recipeText.text = "3. Put eggs sugar, salt, and lemon zest in stand mixer.";
        else if (cakeNum == 2)
            recipeText.text = "2. Spray and flour cake pan.";
        else
            recipeText.text = "1. Preheat oven to Yellow.";
    }
}
