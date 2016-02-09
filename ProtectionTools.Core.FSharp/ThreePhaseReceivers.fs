namespace ProtectionTools.Core.FSharp

module ThreePhaseReceivers = 
    let sqrt3 = sqrt 3.0
    let CalculatedCurrent (мощность: float<Measures.кВт>) (номинальное_напряжение: float<Measures.В>) cosF coef = 
        мощность / (sqrt3 * номинальное_напряжение * cosF * coef)

        

