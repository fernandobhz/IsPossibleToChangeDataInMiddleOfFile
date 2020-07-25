Imports System.IO

Module Main

    Sub Main()

        Dim Lock As New FileStream("C:\temp\x.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

        Dim F As New FileStream("C:\temp\x.txt", FileMode.Open, FileAccess.Write, FileShare.Read)
        F.Seek(5, SeekOrigin.Begin)

        Dim Buff() As Byte = System.Text.Encoding.UTF8.GetBytes("X")
        F.Write(Buff, 0, Buff.Length)
        F.Close()

        MsgBox("Done")

    End Sub

End Module
