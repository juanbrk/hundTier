Public Class CombosDAO
    Private Property str_sql = ""

    Friend Function cargarBarrios() As DataTable
        str_sql = "SELECT * FROM Barrios WHERE 1=1"
        Dim tabla As DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL(str_sql)
        Try
            If tabla.Rows.Count > 0 Then
                Return tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Friend Function cargarRazasPerros() As DataTable
        str_sql = "SELECT * FROM Razas_Perros WHERE 1=1"
        Dim tabla As DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL(str_sql)
        Try
            If tabla.Rows.Count > 0 Then
                Return tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Friend Function cargarColores() As DataTable
        str_sql = "SELECT * FROM Colores WHERE 1=1"
        Dim tabla As DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL(str_sql)
        Try
            If tabla.Rows.Count > 0 Then
                Return tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Friend Function cargarSexos() As DataTable
        str_sql = "SELECT * FROM Sexo_animal WHERE 1=1"
        Dim tabla As DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL(str_sql)
        Try
            If tabla.Rows.Count > 0 Then
                Return tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Friend Function cargarEdadesAnimal() As DataTable
        str_sql = "SELECT * FROM Edad_animal WHERE 1=1"
        Dim tabla As DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL(str_sql)
        Try
            If tabla.Rows.Count > 0 Then
                Return tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Friend Function cargarTamanosAnimal() As DataTable
        str_sql = "SELECT * FROM Tamano_animal WHERE 1=1"
        Dim tabla As DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL(str_sql)
        Try
            If tabla.Rows.Count > 0 Then
                Return tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Friend Function cargarPelosAnimal() As DataTable
        str_sql = "SELECT * FROM Pelo_animal WHERE 1=1"
        Dim tabla As DataTable
        tabla = BDHelper.getDBHelper.ConsultaSQL(str_sql)
        Try
            If tabla.Rows.Count > 0 Then
                Return tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function






End Class
