namespace Restaurant.Food.Domain

type FoodAttributeId = FoodAttributeId of string
type FoodAttributeName = FoodAttributeId of string



type FoodAttribute = {
    Id:FoodAttributeId
    Name:FoodAttributeName
    }
    
type FoodAttributes = FoodAttributes of FoodAttribute array

module FoodAttribute =
    let create id name = {
        Id= id
        Name = name
    }
