open System

let isLeap (year : int) =
  if (year % 400) = 0 then true
  elif (year % 4 = 0) && (year % 100 <> 0) then true
  else false  

let daysInYear (year : int) = 
  if (isLeap year) then 365+1 else 365

let daysToEndYear (year : int) =
  [1..year] |> List.map daysInYear |> List.sum

let daysToEndMonth (month : int, year : int) =
  
  let correction =
    if month > 1 then
      if (isLeap year) then 1 else 2
    else 0

  ((367 * month + 5) / 12 - correction) + (daysToEndYear (year - 1))

let eraDay (day : int, month : int, year : int) = 
  let noOfDaysInGivenMonth = DateTime.DaysInMonth(year, month)
  daysToEndMonth(month, year) - (noOfDaysInGivenMonth - day)

printfn "%A" (eraDay (1, 1, 1))
printfn "%A" (eraDay (22, 9, 1792))
printfn "%A" (eraDay (12, 3, 1999))
printfn "%A" (eraDay (19, 7, 622))
