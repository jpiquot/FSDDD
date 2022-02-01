namespace Restaurant.DinningArea.Domain

type DinningRoomId = DinningRoomId of string
type DinningRoomDescription = DinningRoomDescription of string
type DinningRoomTables =  DinningRoomTables of Tables 

type DinningRoom={
 Id: DinningRoomId
 Description: DinningRoomDescription 
 Tables: DinningRoomTables
}

module DinningRoom = 
 let create id description tables = {
  Id = id
  Description = description
  Tables = tables
}

