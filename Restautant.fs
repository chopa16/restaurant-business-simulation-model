namespace File1
open System
type restaurant(numberOfTable:int, guestStayTimeInR:int) = class
    let l = [1..1080000]
    let f = [1..15]
    let mutable fd = 0
    let t = 
        seq{
            for i in f do
                fd<-(let rndGen = new Random(int DateTime.Now.Ticks)
                     rndGen.Next(3, 15))
                let li = l|>List.map(fun x->x+1)
                yield fd 
            }
   // let ti = t
    member x.NumberOfTable
        with get() : int = numberOfTable
    member x.GuestStayTimeInR
        with get() : int = guestStayTimeInR
    member x. Time =  t
    end