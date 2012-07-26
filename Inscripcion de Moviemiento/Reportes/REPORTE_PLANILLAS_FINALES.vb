Imports System.Data.OracleClient
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class REPORTE_PLANILLAS_FINALES
    Public NombrePartido As String
    Public NombreMovimiento As String

   
   
    Private Sub REPORTE_PLANILLAS_FINALES_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow



        'Dim data As New DS_REPORTE_CANDIDATOS
        'Using data1 As New DS_REPORTE_CANDIDATOSTableAdapters.IM_DEP_CANDIDATOSTableAdapter
        '    data1.Fill(data.IM_DEP_CANDIDATOS)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreDep" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = data.IM_DEP_CANDIDATOS
        '        LookUpEdit.Properties.DisplayMember = "DEPARTAMENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "DEPARTAMENTO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("DEPARTAMENTO", 0, "DEPARTAMENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next


        'Dim dataset As New DS_PLANILLA_TOTALES
        'Using Adapter As New DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        '    Adapter.FillBy(dataset.IM_PARTIDOS_POLITICOS, partido)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombrePartido" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_PARTIDOS_POLITICOS
        '        LookUpEdit.Properties.DisplayMember = "NOMBRE PARTIDO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "NOMBRE PARTIDO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NOMBRE PARTIDO", 0, "NOMBRE PARTIDO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next

        '' ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
        'Using Adapter1 As New DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOSTableAdapter
        '    Adapter1.Fill(dataset.IM_MOVIMIENTOS)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreMovimiento" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_MOVIMIENTOS
        '        LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "NOMBRE MOVIMIENTO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next

        'Using Adapter1 As New DS_PLANILLA_TOTALESTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
        '    Adapter1.Fill(dataset.IM_NIVEL_ELECTIVO)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "nivel" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_NIVEL_ELECTIVO
        '        LookUpEdit.Properties.DisplayMember = "NIVEL ELECTIVO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "NIVEL ELECTIVO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NIVEL ELECTIVO", 0, "NIVEL ELECTIVO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next

        '**********************

        'Using Adapter As New DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
        '    Adapter.Fill(dataset.IM_MUNICIPIOS, "CHOLUTECA")
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreMunicipio" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_MUNICIPIOS
        '        LookUpEdit.Properties.DisplayMember = "DESCRIPCION" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "DESCRIPCION"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("DESCRIPCION", 0, "DESCRIPCION")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next

        ''Dim dataset As New DS_PLANILLA_TOTALES
        'Using Adapter2 As New DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
        '    Adapter2.Fill(dataset.IM_MUNICIPIOS)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreMunicipio" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_MUNICIPIOS
        '        LookUpEdit.Properties.DisplayMember = "DESCRIPCION" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "DESCRIPCION"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("DESCRIPCION", 0, "DESCRIPCION")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next
        'Me.IM_CANDIDATOSTableAdapter.FillBy(Me.DS_PLANILLA_TOTALES1.IM_CANDIDATOS,
        'Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_PARTIDOS_POLITICOS_imagen, "PARTIDO LIBERAL DE HONDURAS")
        'Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento)


    End Sub

    Private Sub REPORTE_PLANILLAS_FINALES_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Dim oradb As String = Configuracion.verconfig
        Dim conn As New OracleConnection()
        Dim myCMD As New OracleCommand()
        'Dim mensaje As String
        Dim cdesignados As String = 0
        Dim parlacen1 As String = 0
        Dim total_presidencial As String = 0
        Dim cpresidente As String = 0
        Dim parlacen2 As String = 0
        Dim tnivel_presidencial As String = 0
        Dim tnivel_designados As String = 0
        Dim tnivel_diputadospp As String = 0
        Dim tnivel_diputadosps As String = 0
        ''variables nivel congreso nacional
        Dim tnivel_diputadoscnp As String = 0
        Dim tnivel_diputadoscns As String = 0
        Dim tnivel_diputadospac As String = 0
        Dim tnivel_diputadossac As String = 0

        Dim identidades As String = 0
        Dim total_general As String = 0

        conn.ConnectionString = oradb
        conn.Open()

        'AREA DE ASIGNACION A CAMPOS DEL FILTRO
        'Me.partidopolitico.Text = NombrePartido.Value.ToString
        'Me.movimientopolitico.Text = NombreMovimiento.Value.ToString
        'Me.nivelelectivo.Text = nivel.Value.ToString
        'Me.ndepartamento.Text = NombreDep.Value.ToString

        'AREA DE CONSULTAS

        total_presidencial = COracle.ObtenerDatos("Select sum(CANTIDAD_CARGO) CANTIDAD_CARGO FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_NIVEL_ELECTIVO = 1", "CANTIDAD_CARGO")
        parlacen1 = COracle.ObtenerDatos("Select sum(CANTIDAD_CARGO) CANTIDAD_CARGO FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO = 2", "CANTIDAD_CARGO")
        cpresidente = COracle.ObtenerDatos("Select sum(CANTIDAD_CARGO) CANTIDAD_CARGO FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO = 1", "CANTIDAD_CARGO")
        cdesignados = COracle.ObtenerDatos("Select sum(CANTIDAD_CARGO) CANTIDAD_CARGO FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO = 9", "CANTIDAD_CARGO")
        parlacen2 = COracle.ObtenerDatos("Select sum(CANTIDAD_CARGO) CANTIDAD_CARGO FROM IM_CARGOS_ELECTIVOS WHERE CODIGO_CARGO_ELECTIVO = 3", "CANTIDAD_CARGO")
        ''TOTALES DE LA POR PARTIDO Y MOVIMIENTOS 
        tnivel_presidencial = COracle.ObtenerDatos("select count(*) CANTIDAD_CARGO  from im_candidatos C,im_partidos_politicos p, im_movimientos m where C.CODIGO_CARGO_ELECTIVO in (1) and C.ESTADO ='H' and C.CODIGO_PARTIDO = P.CODIGO_PARTIDO and C.CODIGO_PARTIDO  = M.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO =M.CODIGO_MOVIMIENTO and P.NOMBRE ='" & Me.partidopolitico.Text & "' AND M.NOMBRE_MOVIMIENTO ='" & Me.movimientopolitico.Text & "'", "CANTIDAD_CARGO")
        tnivel_designados = COracle.ObtenerDatos("select count(*) CANTIDAD_CARGO  from im_candidatos C,im_partidos_politicos p, im_movimientos m where C.CODIGO_CARGO_ELECTIVO in (9) and C.ESTADO ='H' and C.CODIGO_PARTIDO = P.CODIGO_PARTIDO and C.CODIGO_PARTIDO  = M.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO =M.CODIGO_MOVIMIENTO  and P.NOMBRE ='" & Me.partidopolitico.Text & "' AND M.NOMBRE_MOVIMIENTO ='" & Me.movimientopolitico.Text & "'", "CANTIDAD_CARGO")
        tnivel_diputadospp = COracle.ObtenerDatos("select count(*) CANTIDAD_CARGO  from im_candidatos C,im_partidos_politicos p, im_movimientos m where C.CODIGO_CARGO_ELECTIVO in (2) and C.ESTADO ='H' and C.CODIGO_PARTIDO = P.CODIGO_PARTIDO and C.CODIGO_PARTIDO  = M.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO =M.CODIGO_MOVIMIENTO and P.NOMBRE ='" & Me.partidopolitico.Text & "' AND M.NOMBRE_MOVIMIENTO ='" & Me.movimientopolitico.Text & "'", "CANTIDAD_CARGO")
        tnivel_diputadosps = COracle.ObtenerDatos("select count(*) CANTIDAD_CARGO  from im_candidatos C,im_partidos_politicos p, im_movimientos m where C.CODIGO_CARGO_ELECTIVO in (3) and C.ESTADO ='H' and C.CODIGO_PARTIDO = P.CODIGO_PARTIDO and C.CODIGO_PARTIDO  = M.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO =M.CODIGO_MOVIMIENTO and P.NOMBRE ='" & Me.partidopolitico.Text & "' AND M.NOMBRE_MOVIMIENTO ='" & Me.movimientopolitico.Text & "'", "CANTIDAD_CARGO")
        ''TOTALES DIPUTADOS AL CONGRESO NACIONAL
        tnivel_diputadoscnp = COracle.ObtenerDatos("Select SUM(CANTIDAD_DIPUTADOS)CANTIDAD_CARGO FROM IM_DEPARTAMENTOS where descripcion='" & Me.ndepartamento.Text & "'", "CANTIDAD_CARGO")
        tnivel_diputadoscns = tnivel_diputadoscnp.ToString
        tnivel_diputadospac = COracle.ObtenerDatos("SELECT count(*)CANTIDAD_CARGO FROM IM_DEPARTAMENTOS d, im_v_mostrar_candidatos2 a, im_cargos_electivos ca where A.CODIGO_DEPARTAMENTO = D.CODIGO_DEPARTAMENTO and A.CODIGO_CARGO_ELECTIVO = CA.CODIGO_CARGO_ELECTIVO and D.DESCRIPCION   ='" & Me.ndepartamento.Text & "' and CA.CODIGO_NIVEL_ELECTIVO  = 2", "CANTIDAD_CARGO")


        'AREA DE ASIGNACION A CAMPOS DEL REPORTE 
        ' Me.total.Text = total_presidencial.ToString 'asigno el total de candidatos nivel presidencial
        'Me.totalpp.Text = parlacen1.ToString 'asigno el total de candidatos al parlacen propietario
        'Me.totalpre.Text = cpresidente.ToString 'asigno el total de candidatos a presidencia
        'Me.totalde.Text = cdesignados.ToString 'asigno el total de designados presidenciales
        'Me.totalsp.Text = parlacen2.ToString 'asigno el total de candidatos al parlacen suplentes
        'Me.total_presidencial.Text = tnivel_presidencial.ToString 'asigno el numero candidato presidencial actual
        'Me.total_designado.Text = tnivel_designados.ToString 'asigno el numero de designados actuales
        'Me.totalparp.Text = tnivel_diputadospp.ToString
        'Me.totalpars.Text = tnivel_diputadosps.ToString
        ' ''NIVEL DIPUTADOS
        'Me.totaldipup.Text = tnivel_diputadoscnp.ToString
        'Me.totaldipus.Text = tnivel_diputadoscns.ToString
        'Me.total_dipp.Text = tnivel_diputadospac.ToString
        'Me.total_dips.Text = tnivel_diputadospac.ToString


        'PASO LOS PARAMETROS A MI DATA SET PARA HACER EL FILTRADO EN LA CONSULTA
        'Me.IM_CANDIDATOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES1.IM_CANDIDATOS, Me.partidopolitico.Text, Me.movimientopolitico.Text, Me.nivelelectivo.Text, Me.ndepartamento.Text)
        ''Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES1.IM_DEPARTAMENTOS, NombreDep.Value.ToString)
        'Me.DT_totalTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.DT_total, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString, Me.NombreDep.Value.ToString, Me.nivel.Value.ToString)
        'cierro conexion
        conn.Close()
        'MsgBox(Me.partidopolitico.Text & Me.movimientopolitico.Text)
        'If Me.nivel.Value.ToString <> "CORPORACION MUNICIPAL" Then
        '    Me.muniname.Visible = False
        '    Me.munivalor.Visible = False

        'Else
        '    Me.muniname.Visible = True
        '    Me.munivalor.Visible = True
        'End If

        'If Me.nivel.Value.ToString <> "DIPUTADOS AL CONGRESO NACIONAL" Then
        '    Me.diputados.Visible = False
        '    Me.diputadosactuales.Visible = False
        'Else
        '    Me.diputados.Visible = True
        '    Me.diputadosactuales.Visible = True
        'End If

    End Sub
End Class