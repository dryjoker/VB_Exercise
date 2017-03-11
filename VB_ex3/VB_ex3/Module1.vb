Module Module1

    Sub Main() '主程式區域
        'Dim 變數名稱 As 資料型態 = 初始值
        Dim intNum As Integer = 250
        intNum += 1
        '常數
        Const pi As Single = 3.14159
        Console.WriteLine(intNum) '會換列
        Console.Write(pi) '不會換列

        'Dim doubleNum As Double = 1.5
        'Const 常數名稱 As 資料型態 = 運算式

        Const ok As Byte = 1, nok As Byte = 0
        Const br_day As Date = #01/24/2011#
        Const sw As String = "Y"

        Console.Read()
    End Sub

End Module
