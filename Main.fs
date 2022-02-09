open System
open File1
open  System.Collections.Generic
open System.Windows.Forms
open System.Drawing
[<EntryPoint>]
let main argv =
    printfn "%A" argv
    //let listTime = [1..10800]//интервал времени завтрока
    //let yt = printfn "%i" (listTime|>List.length) 
    let mutable ListOfTable4 = []
    let mutable ListOfTable3 = []
    let mutable ListOfTable2 = []
    let mutable ListOfTable1 = []
    let mutable ListTime1 = []
    let mutable ListTime2 = []
    let mutable ListTime3 = []
    let mutable ListTime5 = 0
    let ListTime4 = []
    let queue = []
   // let seqTable = 
        //seq {
    let rand(a,b) =
        let rndGen = new Random(int DateTime.Now.Ticks)
        rndGen.Next(a, b)
    let ListTime = [1..180]//в минутах
    let mutable Table = 1
    let mutable IntervalArrival = rand(1, 10)//в минутах лучше была бы использовать нормальное распределение
    let mutable r = 1
    let mutable total = 0
    let mutable puple = 1
    let mutable randguestStayTimeInR = 0
    let mutable LeftG4 = 0
    let mutable LeftG3 = 0
    let mutable LeftG2 = 0
    let mutable LeftG1 = 0
    let mutable M = 0
    let mutable M2 = seq{0}
    let mutable queue = []
    ListTime5 <-let rndGen = new Random(int DateTime.Now.Ticks)
                rndGen.Next(80, 100)
    let Place4 = 10
    let Place3 = 10
    let Place2 = 3
    let Place1 = 4
    let mutable l = 0
    let factTotal = 200
    let mutable timeQueue = []
    let dfv = new restaurant(LeftG4, IntervalArrival)
    let mutable tImeQueue = dfv.Time
    let mutable T0tal = []
    M<-ListTime5
    let funct f = f + rand(-2,2)
    let seqR = 
        seq{
            for i in ListTime do
                let executable =  
                    let rndGen = new Random(int DateTime.Now.Ticks)
                    let values = [0.00..100.00]
                    let Gauss (center:float, sigma:float) =
                        let h = 2.0
                        let gd = center+sigma*(rndGen.NextDouble()*rndGen.NextDouble()+rndGen.NextDouble()+rndGen.NextDouble()-h)/h
                        gd
                    M<-rand(80, 100)
                    let CheckQueue = 
                        if queue|>List.length>0 then true //func (List.item l queue)
                            else false
                    let RecordtimeQueue head = timeQueue<-(snd head)::timeQueue
                    let DeleteTheLast = 
                        let q = queue|>List.rev
                        let f = match q with
                                |head::tail->RecordtimeQueue head
                                             tail 
                                |_->[]
                        
                        queue<-f|>List.rev
                    let RecordPlace puple1= 
                        match r with 
                        |4->if LeftG4<Place4 then LeftG4<-LeftG4+1
                                                  //printfn "Люди заходят они сидят примерно"
                                                  //printfn "%d" puple1
                                                  //Console.WriteLine(puple1)
                                                  ListOfTable4<-(puple1,randguestStayTimeInR)::ListOfTable4//(LiPlace4|>List.length)<10 then LiPlace1::true else queue 
                                                  if CheckQueue then DeleteTheLast 
                                else queue<-(puple1, 0)::queue
                              
                        |3->if LeftG3<Place3 then LeftG3<-LeftG3+1
                                                 // printfn "%d" puple1
                                                  ListOfTable3<-(puple1,randguestStayTimeInR)::ListOfTable3//(LiPlace4|>List.length)<10 then LiPlace1::true else queue 
                                                  if CheckQueue then DeleteTheLast
                                else  queue<-(puple1, 0)::queue
                        |2->if LeftG2<Place2 then LeftG2<-LeftG2+1
                                                  //printfn "%d" puple1
                                                  ListOfTable2<-(puple1,randguestStayTimeInR)::ListOfTable2//(LiPlace4|>List.length)<10 then LiPlace1::true else queue 
                                                  if CheckQueue then DeleteTheLast
                                else  queue<-(puple1, 0)::queue
                        |_->if LeftG1<Place1 then LeftG1<-LeftG1+1
                                                  printfn "%d" puple1
                                                  ListOfTable1<-(puple1,randguestStayTimeInR)::ListOfTable1//(LiPlace4|>List.length)<10 then LiPlace1::true else queue 
                                                  if CheckQueue then DeleteTheLast
                                else  queue<-(puple1, 0)::queue
                                      //printfn "%d" puple1
                    let func puple1= 
                        if puple1 = 4 then //r<- rand(3,5)
                                      total<-total+puple1
                                      //(puple, r, randguestStayTimeInR) :: ListOfTable4
                                      RecordPlace puple1
                                      //printfn "%d" puple1
                                      //printfn "%d" r
                                      //printfn "%d" randguestStayTimeInR
                            else if puple1 = 3 then r<- rand(3,5)
                                                    total<-total+puple1
                                                    RecordPlace puple1
                                                    
                                                    //printfn "%d" r
                                                    //printfn "%d" randguestStayTimeInR
                                 else if puple1 = 2 then r<- rand(2,5)
                                                         total<-total+puple1
                                                         RecordPlace puple1
                                                         //printfn "%d" puple1
                                                         //printfn "%d" r
                                                        // printfn "%d" randguestStayTimeInR
                                    else total<-total+puple1 
                                         RecordPlace puple1
                                         //printfn "%d" puple1
                                         //printfn "%d" r
                                         //printfn "%d" randguestStayTimeInR                                                  printfn "%d" r
                                     // printfn "%d" randguestStayTimeInR
                 
                    IntervalArrival <- IntervalArrival - 1
                //printfn "Интервал, обратный осчет"
                //printfn "%d" IntervalArrival
                    Console.WriteLine(i)
                    if IntervalArrival = 0 then IntervalArrival <- IntervalArrival+rand(1, 5)
                                                puple <- rand(1,5)
                                                
                                                randguestStayTimeInR<-rand(1, 3)
                                                //Console.WriteLine(randguestStayTimeInR)
                                                func puple
                                            //Console.WriteLine(randguestStayTimeInR)
                    ListOfTable4<-ListOfTable4|>List.map(fun ((x, t ):(int*int))-> (x, (if t>0 then t-1 else LeftG4<-LeftG4-1
                                                                                                             LeftG4)))
                    ListOfTable3<-ListOfTable3|>List.map(fun ((x,  t ):(int*int))-> (x, (if t>0 then t-1 else LeftG3<-LeftG3-1
                                                                                                              LeftG3)))
                    ListOfTable2<-ListOfTable2|>List.map(fun ((x, t ):(int*int))-> (x, (if t>0 then t-1 else LeftG2<-LeftG2-1 
                                                                                                             LeftG2)))
                    ListOfTable1<-ListOfTable1|>List.map(fun ((x, t ):(int*int))-> (x,(if t>0 then t-1 else LeftG1<-LeftG1-1
                                                                                                            LeftG1)))
                    queue<-queue|>List.map(fun (x,y)->(x, y+1))
                //ListOfTable4|>List.//(fun ((x, y, t ):(int*int*int))->
                    l<-(queue|>List.length)-1
                
                    let CheckQueueFindFree = 
                        if CheckQueue then func (fst (List.item l (queue)))
                    CheckQueueFindFree

                     
            
                M<-M+total
                    
                if total<factTotal then executable
                yield IntervalArrival
                      }
    printfn "Ввести количество столов в ресторане"
    let a = System.Console.Read()
    let fd = seqR
    //let FindBool =
    let mutable f = []
    let d = if a<50 then tImeQueue<-[40]
                else if a>400 then tImeQueue<-[]
    let FindM = 
        f <- timeQueue|>List.map(fun x->(if x>15 then true else false))
        seqR
        //if f>0 then seqR else M2
    (*let writeStringToFile d tImeQueue=
        for x in tImeQueue do
            (System.IO.File.OpenWrite("fl.scv"), d)
            |> fun ((s : System.IO.FileStream), (d : string)) -> let r = new System.IO.StreamWriter(s)
                                                                 r.WriteLine(x + ";")
                                                                 r.Write(d)
                                                                 r.Close()
                                                                 s.Close()*)
    //System.IO.File.AppendAllText("C:\\Users\\chopulai\\source\\repos\\ConsoleApplication4\\file.csv","\n") 
    (*let pg = tImeQueue|>Seq.iter(fun x-> System.IO.File.AppendAllText("C:\\Users\\chopulai\\source\\repos\\ConsoleApplication4\\file.csv",Convert.ToString(x) + ";")) 
                                    //     Console.Write("\n" + Convert.ToString(x) + ";"))*)
    let le = tImeQueue|>Seq.length
    
    let max = tImeQueue|>Seq.max 
    let min = tImeQueue|>Seq.min
    let l = [0..le-1]
    let sop = 
        seq{
            for n=0 to le-1 do
            yield funct (tImeQueue|>Seq.item n)}
    let pg = tImeQueue|>Seq.iter(fun x-> System.IO.File.AppendAllText("C:\\Users\\chopulai\\source\\repos\\ConsoleApplication4\\file.csv",Convert.ToString(x) + ";")) 
    //     Console.Write("\n" + Convert.ToString(x) + ";"))

    let funct x y= x+y
    System.IO.File.AppendAllText("C:\\Users\\chopulai\\source\\repos\\ConsoleApplication4\\file.csv","\n") 
    let ph = sop|>Seq.iter(fun x-> System.IO.File.AppendAllText("C:\\Users\\chopulai\\source\\repos\\ConsoleApplication4\\file.csv",Convert.ToString(x) + ";")) 
    
                                 
    let avarege = (tImeQueue|>Seq.reduce funct)/(tImeQueue|>Seq.length)
    printfn "Время ожидание свободного столика"
    printfn "max = "
    Console.WriteLine(max)
    printfn "min = "
    Console.WriteLine(min)
    printfn "При max время ожидания<15 количество столиков M = "
    Console.WriteLine(M)
    System.IO.File.AppendAllText("C:\\Users\\chopulai\\source\\repos\\ConsoleApplication4\\file.csv","\n") 
    let pr = l|>Seq.iter(fun x-> System.IO.File.AppendAllText("C:\\Users\\chopulai\\source\\repos\\ConsoleApplication4\\file.csv",Convert.ToString(x) + ";")) 

    

    //Console.WriteLine(averege)
    //let pg = ListOfTable4|>List.map(fun x-> Console.WriteLine(x))
    //Console.WriteLine(Seq.length seqR)

    0


