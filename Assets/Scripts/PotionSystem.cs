using System.Collections.Generic;
using UnityEngine;

public class PotionSystem : MonoBehaviour
{
    public PotionSpawner spawner;
    public Cauldron cauldron; 

    public GameObject Eye;
    public GameObject BigMashrum;
    public GameObject SmallCarrot;

    public void BrewPotion()
    {
        List<IngredientType> ingredients = cauldron.currentIngredients;
        // vision potion

        if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Count == 2)
        {
            Debug.Log("Vision potion worked!");
            spawner.Spawn(SmallCarrot);
        }
        else if (ingredients.Contains(IngredientType.Eye) &&
            ingredients.Contains(IngredientType.Watermelon) &&
            ingredients.Count == 2)
        {
           
            Debug.Log("Strong potion done!");
            spawner.Spawn(BigMashrum);
        }

        cauldron.ClearCauldron();
    }
}