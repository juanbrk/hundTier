Public Class BarriosDao
    Friend Function getAll() As List(Of Barrio)
        Dim nuevoBarrio As Barrio
        Dim listaBarrios As New List(Of Barrio)
        Dim strSQL = "SELECT * FROM Barrios"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Barrio a partir de los datos de la/s filas de la tabla Barrio

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            nuevoBarrio = New Barrio()
            With nuevoBarrio
                .setID(row.Item("id_barrio").ToString)
                .setNombre(row.Item("nombre").ToString)
            End With
            listaBarrios.Add(nuevoBarrio)
        Next

        Return listaBarrios
    End Function

    Friend Function getNombreDeBarrio(idBarrio As Integer) As String
        Return BDHelper.getDBHelper.ConsultaSQL("SELECT  b.nombre AS 'nombre_barrio' From Barrios b Where b.id_barrio =" & idBarrio).Rows(0).Item("nombre_barrio").ToString()
    End Function
End Class
