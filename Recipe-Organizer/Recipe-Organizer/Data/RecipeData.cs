using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe_Organizer.Data;

public static class RecipeList
{
    public static Recipe[] Recipes => [
        new(
            name: "Porridge",
            description: "Basic Porridge Recipe",
            servings: 2,
            preperationTime: 10.0
            instructions: [
                "Put rolled oats and water ihnto saucepan",
                "Bring to boil on high",
                "Reduce to simmer for 10 minutes"
            ],
            ingredients: [
                ("Rolled oats", 1),
                ("Water", 2)
                ]
            )
        ];
}
