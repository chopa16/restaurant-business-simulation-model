namespace File1

type restaurant(numberOftable:int, guestStayTimeInR:int) = class
    let execute = printfn"хорошего отдыха"
    member x.NumberOftable
        with get() : int = numberOftable
    member x.GuestStayTimeInR
        with get() : int = guestStayTimeInR
    member x.CurrentOccupancyRateOfHotel = execute 
   // member x.executee farg = Comp farg
    end
    