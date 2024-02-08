

//Questao 1 ------------------------------------------------------------------
    printfn "QUESTAO 1"
    printfn " "


    let divisaoMaiorPorMenor valor1 valor2 =
        if valor1 >= valor2 then
            float valor1 / float valor2
        else
            float valor2 / float valor1

    let resultado = divisaoMaiorPorMenor 10 5
    printfn "Resultado %f" resultado

    let resultado2 = divisaoMaiorPorMenor 25 2
    printfn "Resultado %f" resultado2


//Questao 2 ------------------------------------------------------------------
    printfn " "
    printfn "QUESTAO 2"
    printfn " "


    let tipoTriangulo lado1 lado2 lado3 =
        if lado1 >= lado2 + lado3 || lado2 >= lado1 + lado3 || lado3 >= lado1 + lado2 then
            printfn "Não forma um triângulo"
        elif lado1 = lado2 && lado2 = lado3 then
            printfn "Equilátero - Todos os lados iguais"
        elif lado1 = lado2 || lado1 = lado3 || lado2 = lado3 then
            printfn "Isósceles - Dois lados iguais"
        else
            printfn "Escaleno - Todos os lados diferentes"

    tipoTriangulo 3 3 3
    tipoTriangulo 3 1 5 
    tipoTriangulo 3 3 4
    tipoTriangulo 6 8 10



//Questao 3 ------------------------------------------------------------------
    printfn " "
    printfn "QUESTAO 3"
    printfn " "

    let isPar x = x % 2 = 0

    let isMultiploDeSeis x = x % 6 = 0

    let dobrar x = x * 2

    let vetor = [0..20]

    let valoresPares =
        vetor
        |> List.filter isPar                      
    printfn "Valores pares: %A" valoresPares

    let valoresParesDobrados =
        valoresPares
        |> List.map dobrar
    printfn "Valores pares multiplicados por 2: %A" valoresParesDobrados

    let valoresMultiplosDeSeis =
        valoresParesDobrados
        |> List.filter isMultiploDeSeis
    printfn "Valores múltiplos de 6: %A" valoresMultiplosDeSeis

//Questao 4 ------------------------------------------------------------------
    printfn " "
    printfn "QUESTAO 4"
    printfn " "


    let resultadoNotas () =
        let calcularMedia n1 n2 n3 = (n1 + n2 + n3) / 3.0
        let verificarAprovacao media = if media >= 6.0 then true else false
        let mensagemResultado aprovado =
            if aprovado then
                printfn "Aluno foi aprovado"
            else
                printfn "Aluno foi reprovado"

        printfn "Digite as três notas:"
        let nota1 = float(System.Console.ReadLine())
        let nota2 = float(System.Console.ReadLine())
        let nota3 = float(System.Console.ReadLine())

        let media = calcularMedia nota1 nota2 nota3
        printfn "Media %f" media
        let aprovado = verificarAprovacao media
        mensagemResultado aprovado

    // Chamando a função principal
    resultadoNotas()

    printfn "Fim das atividades, pressione qualquer tecla para sair"
    System.Console.ReadLine()
// --------------------------------------------------------------------------