Module Module1

    Sub Main()
        'Byte -->  2^8 -1 (0~255)
        '使用一個位元組來表示資料(不含小數點之數字)
        Dim a As Byte ' Byte ---> 不帶符號之位元組(0~255)
        a = 42
        Dim b As Byte
        'b = -2   ' --->error 只有正的不可有負的

        'SByte -->  2^7-1 ~ -2^7 (127~-128)
        '使用一個位元組來表示資料(不含小數點之數字)
        Dim c As SByte
        'c = 128   '---->error 超出範圍 

        'Short --> 2byte ( 16bit)表示 2^15-1~-2^15(32767~ -32768)
        '帶符號的短整數(0、正/負整數) , 不含小數
        Dim d As Short
        'd = 32768  '---->error 超出範圍 

        'Integer -->4byte(32bit)表示 2^31-1~-2^31 (2147483647~ -2147483648)
        '帶符號的整數
        Dim e As Integer
        e = 2147483647

        'Long  --> 8byte(64bit)表示 2^63-1 ~ -2^63 
        Dim f As Long
        f = 214748364812

        '單準度數
        Dim singleNum As Single
        singleNum = 2.6

        '倍準度數
        Dim doubleNum As Double
        doubleNum = 8.0E-41



    End Sub

End Module
