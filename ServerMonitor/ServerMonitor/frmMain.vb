Imports System.Net.Sockets
Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServerList()

    End Sub

    Sub ServerList()
        Amsterdam()
        Atlanta()
        Australia()
        Australia2()
        Australia3()
        Australia4()
        Brazil()
        Dallas()
        France()
        Germany()
        Iceland()
        India()
        LondonUK()
        LosAngeles()
        Malaysia()
        Netherland()
        NewJersey()
        Panama()
        Romania()
        Russia()
        Singapore()
        SouthAfrica()
        Spain()
        Sweden()
        Switzerland()
        Tokyo()
        Turkey()
        UK()
        Ukraine()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ServerList()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ServerList()
    End Sub

    Private Sub btnRefreshnews_Click(sender As Object, e As EventArgs) Handles btnRefreshnews.Click
        WebBrowser.Navigate("")
    End Sub

    Sub Amsterdam()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("108.61.103.188", 22)

        Catch generatedExceptionName As Exception
            lblAmsterdamS.Text = "OFFLINE"
            lblAmsterdamS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblAmsterdamS.Text = "ONLINE"
            lblAmsterdamS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Atlanta()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("108.61.252.20", 22)

        Catch generatedExceptionName As Exception
            lblAtlantaS.Text = "OFFLINE"
            lblAtlantaS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblAtlantaS.Text = "ONLINE"
            lblAtlantaS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Australia()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("108.61.212.67", 22)

        Catch generatedExceptionName As Exception
            lblAustralia1S.Text = "OFFLINE"
            lblAustralia1S.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblAustralia1S.Text = "ONLINE"
            lblAustralia1S.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Australia2()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("151.236.10.173", 22)

        Catch generatedExceptionName As Exception
            lblAustralia2S.Text = "OFFLINE"
            lblAustralia2S.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblAustralia2S.Text = "ONLINE"
            lblAustralia2S.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Australia3()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("151.236.10.140", 22)

        Catch generatedExceptionName As Exception
            lblAustralia3S.Text = "OFFLINE"
            lblAustralia3S.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblAustralia3S.Text = "ONLINE"
            lblAustralia3S.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Australia4()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("151.236.11.206", 22)

        Catch generatedExceptionName As Exception
            lblAustralia4S.Text = "OFFLINE"
            lblAustralia4S.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblAustralia4S.Text = "ONLINE"
            lblAustralia4S.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Brazil()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("191.96.4.2", 22)

        Catch generatedExceptionName As Exception
            lblBrazilS.Text = "OFFLINE"
            lblBrazilS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblBrazilS.Text = "ONLINE"
            lblBrazilS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Dallas()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("108.61.205.194", 22)

        Catch generatedExceptionName As Exception
            lblDallasS.Text = "OFFLINE"
            lblDallasS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblDallasS.Text = "ONLINE"
            lblDallasS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub France()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("108.61.208.197", 22)

        Catch generatedExceptionName As Exception
            lblFranceS.Text = "OFFLINE"
            lblFranceS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblFranceS.Text = "ONLINE"
            lblFranceS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Germany()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("130.255.72.220", 22)

        Catch generatedExceptionName As Exception
            lblGermanyS.Text = "OFFLINE"
            lblGermanyS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblGermanyS.Text = "ONLINE"
            lblGermanyS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Iceland()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("192.71.218.131", 22)

        Catch generatedExceptionName As Exception
            lblIcelandS.Text = "OFFLINE"
            lblIcelandS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblIcelandS.Text = "ONLINE"
            lblIcelandS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub India()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("194.71.224.27", 22)

        Catch generatedExceptionName As Exception
            lblIndiaS.Text = "OFFLINE"
            lblIndiaS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblIndiaS.Text = "ONLINE"
            lblIndiaS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub LondonUK()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("108.61.196.121", 22)

        Catch generatedExceptionName As Exception
            lblLondonUKS.Text = "OFFLINE"
            lblLondonUKS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblLondonUKS.Text = "ONLINE"
            lblLondonUKS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub LosAngeles()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("108.61.216.230", 22)

        Catch generatedExceptionName As Exception
            lblLosAngelesS.Text = "OFFLINE"
            lblLosAngelesS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblLosAngelesS.Text = "ONLINE"
            lblLosAngelesS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Malaysia()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("103.1.154.217", 22)

        Catch generatedExceptionName As Exception
            lblMalaysiaS.Text = "OFFLINE"
            lblMalaysiaS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblMalaysiaS.Text = "ONLINE"
            lblMalaysiaS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Netherland()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("46.249.51.162", 22)

        Catch generatedExceptionName As Exception
            lblNetherlandS.Text = "OFFLINE"
            lblNetherlandS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblNetherlandS.Text = "ONLINE"
            lblNetherlandS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub NewJersey()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("64.237.56.119", 22)

        Catch generatedExceptionName As Exception
            lblNewJerseyS.Text = "OFFLINE"
            lblNewJerseyS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblNewJerseyS.Text = "ONLINE"
            lblNewJerseyS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Panama()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("190.123.36.190", 22)

        Catch generatedExceptionName As Exception
            lblPanamaS.Text = "OFFLINE"
            lblPanamaS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblPanamaS.Text = "ONLINE"
            lblPanamaS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Romania()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("109.163.228.228", 22)

        Catch generatedExceptionName As Exception
            lblRomaniaS.Text = "OFFLINE"
            lblRomaniaS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblRomaniaS.Text = "ONLINE"
            lblRomaniaS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Russia()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("88.150.168.219", 22)

        Catch generatedExceptionName As Exception
            lblRussiaS.Text = "OFFLINE"
            lblRussiaS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblRussiaS.Text = "ONLINE"
            lblRussiaS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Singapore()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("128.199.223.129", 22)

        Catch generatedExceptionName As Exception
            lblSingaporeS.Text = "OFFLINE"
            lblSingaporeS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblSingaporeS.Text = "ONLINE"
            lblSingaporeS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub SouthAfrica()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("154.127.61.73", 22)

        Catch generatedExceptionName As Exception
            lblSouthAfricaS.Text = "OFFLINE"
            lblSouthAfricaS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblSouthAfricaS.Text = "ONLINE"
            lblSouthAfricaS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Spain()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("5.134.118.114", 22)

        Catch generatedExceptionName As Exception
            lblSpainS.Text = "OFFLINE"
            lblSpainS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblSpainS.Text = "ONLINE"
            lblSpainS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Sweden()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("95.215.45.34", 22)

        Catch generatedExceptionName As Exception
            lblSwedenS.Text = "OFFLINE"
            lblSwedenS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblSwedenS.Text = "ONLINE"
            lblSwedenS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Switzerland()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("81.17.21.168", 22)

        Catch generatedExceptionName As Exception
            lblSwitzerlandS.Text = "OFFLINE"
            lblSwitzerlandS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblSwitzerlandS.Text = "ONLINE"
            lblSwitzerlandS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Tokyo()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("108.61.200.189", 22)

        Catch generatedExceptionName As Exception
            lblTokyoS.Text = "OFFLINE"
            lblTokyoS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblTokyoS.Text = "ONLINE"
            lblTokyoS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Turkey()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("212.68.41.124", 22)

        Catch generatedExceptionName As Exception
            lblTurkeyS.Text = "OFFLINE"
            lblTurkeyS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblTurkeyS.Text = "ONLINE"
            lblTurkeyS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub UK()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("88.150.168.219", 22)

        Catch generatedExceptionName As Exception
            lblUKS.Text = "OFFLINE"
            lblUKS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblUKS.Text = "ONLINE"
            lblUKS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

    Sub Ukraine()
        Dim logonServer As New TcpClient()

        Try
            logonServer.Connect("91.229.77.105", 22)

        Catch generatedExceptionName As Exception
            lblUkraineS.Text = "OFFLINE"
            lblUkraineS.ForeColor = Color.Red


        End Try
        If logonServer.Connected Then
            lblUkraineS.Text = "ONLINE"
            lblUkraineS.ForeColor = Color.Green
            logonServer.Close()
        End If
    End Sub

End Class
