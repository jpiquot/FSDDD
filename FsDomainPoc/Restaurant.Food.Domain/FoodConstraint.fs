namespace Restaurant.Food.Domain

type FoodConstraintRequired = FoodConstraintRequired of FoodAttributes
type FoodConstraintForbitten = FoodConstraintForbitten of FoodAttributes

type FoodConstraint = {
 Required:FoodConstraintRequired
 Forbitten:FoodConstraintForbitten
} 
 
type FoodConstraints = FoodConstraints of FoodConstraint array

module FoodConstraint =
 let create required forbitten = {
  Required = required
  Forbitten = forbitten
 }

