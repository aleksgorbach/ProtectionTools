namespace ProtectionTools.Core.FSharp

module ReceiversGroup = 
    [<Measure>] type ``В``
    [<Measure>] type ``кВт``

    let CalculatedActivePower (коэффициент_расчётной_мощности) (коэффициент_использования) (номинальная_мощность_приемника: float<кВт>) (количество: int) = 
        коэффициент_расчётной_мощности * коэффициент_использования * номинальная_мощность_приемника * (float количество)

    let ActivePowerCoef количество_приемников =
        if количество_приемников <= 10 then
            1.1
        else
            1.0
            
    let CalculatedReactivePower (коэффициент_расчетной_мощности) (список_потребителей: List<(float*float*float)>)  = 
        let mult (a, b, c) =
            a * b * c
             
        коэффициент_расчетной_мощности * (список_потребителей |> List.map mult |> List.sum)
        

