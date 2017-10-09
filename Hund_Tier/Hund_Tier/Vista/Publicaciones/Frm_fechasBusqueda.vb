Public Class Frm_fechasBusqueda

    Dim fechaDesde As String = ""
    Dim fechaHasta As String = ""

    'Bandera que permitira saber si las fechas son validas. 
    Public flagFechas As Boolean = False


    Private Sub Frm_fechasBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializar componentes:
        clearComponents()
    End Sub
    Private Sub clearComponents()
        txt_fechaDesde.Text = Date.Now.ToString("dd/MM/yyyy")
        txt_fechaHasta.Text = Date.Now.AddDays(1).ToString("dd/MM/yyyy")
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If validarFechas() Then
            Me.Close()
        End If

    End Sub

    Private Function validarFechas() As Boolean

        If IsDate(txt_fechaDesde.Text) And IsDate(txt_fechaHasta.Text) Then
            'Si la fecha en el desde es menor que la fecha en el hasta
            If CDate(txt_fechaDesde.Text) < CDate(txt_fechaHasta.Text) Then
                'Si lo ingresado en el campo fechas son fechas le asignamos el valor a las variables del form
                'Que permitiran recuperarlo desde otra form
                fechaDesde = txt_fechaDesde.Text
                fechaHasta = txt_fechaHasta.Text
                flagFechas = True
            Else
                MsgBox("Las fechas ingresadas no son validas", MsgBoxStyle.OkOnly, "Error en las fechas")
                flagFechas = False
            End If
        End If
        Return flagFechas
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Public Function getFechaDesde() As Date
        Dim fechaFormateada As Date = Date.ParseExact(fechaDesde, "dd/MM/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Return fechaFormateada
    End Function

    Public Function getFechaHasta() As String
        Dim fechaFormateada As Date = Date.ParseExact(fechaHasta, "dd/MM/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Return fechaHasta
    End Function
End Class