namespace Restaurant.DinningArea.Domain

type TableShape =
   | Square = 0
   | Rectangle = 1
   | Round = 2

type TableId = TableId of string
type TableSeats = SeatCount of int

type Table = {
    Id:TableId
    Seats:TableSeats
    Shape: TableShape
}

type Tables = Tables of Table array

module Table =
    let create id shape seats = {
        Id = id
        Shape = shape
        Seats = seats
    }


