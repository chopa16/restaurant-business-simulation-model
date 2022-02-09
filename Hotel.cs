namespace File1
open System
   
type hotel(room:int, guestStayTime:int) = class
    let ch = 
        let execute = printfn"хорошего отдыха"
        let rand()=
            let rndGen = new Random(int DateTime.Now.Ticks)
            rndGen.Next(1, 30)
        let mutable Table = 1
        let mutable IntervalArrival = rand()//в секундах лучше была бы использовать нормальное распределение
        let mutable r = 1
        let mutable total = 0
        let mutable puple = 0
        let s = 
            for i = 1 to 10 do//800 do  
                let se = seq{
                    yield (total<-total+3)
                   }
                se|>ignore s
                                          (*let funct = 
                                              if total<placeInRestaurant then func randguestStayTimeInR puple
                                                  else puple::queue
    member x.Room
        with get() : int = room
    member x.GuestStayTime
        with get() : int = guestStayTime
    member x.CurrentOccupancyRateOfHotel = ch
   // member x.executee farg = Comp farg
    end

