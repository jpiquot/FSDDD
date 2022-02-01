namespace Restaurant.DinningArea.Domain
open Restaurant.Food.Domain

type GuestId = GuestId of string
type GuestFoodConstraints =  GuestFoodConstraints of FoodConstraints


type Guest = {
    Id:GuestId
    Constraints:GuestFoodConstraints
}

module Guest =
    let create id constraints = {
        Id = id
        Constraints = constraints
    }


