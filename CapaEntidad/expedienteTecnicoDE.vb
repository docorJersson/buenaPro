Public Class expedienteTecnicoDE
    Private convocatoria As convocatoriaPublicaDE
    Private cExpediente As Integer
    Private presupuesto As Double
    Private fPresupuesto As Date
    Private fRegistroPre As Date
    Private analisis As String
    Private formulas As String
    Private gestion As String
    Private otrosDoc As String
    Private fRegistroExpe As Date
    Private consultoraObra As consultoraObraDE
    Private terrenosExpe As List(Of terrenoExpedienteDE)
    Private estudio As List(Of estudioTecnicoDE)
    Private aprobacion As aprobacionPublicaDE

    Public Property aprobacionPublica() As aprobacionPublicaDE
        Get
            Return aprobacion
        End Get
        Set(ByVal value As aprobacionPublicaDE)
            aprobacion = value
        End Set
    End Property
    Public Property estudioTecnico() As List(Of estudioTecnicoDE)
        Get
            Return estudio
        End Get
        Set(ByVal value As List(Of estudioTecnicoDE))
            estudio = value
        End Set
    End Property
    Public Property terrenosExpediente() As List(Of terrenoExpedienteDE)
        Get
            Return terrenosExpe
        End Get
        Set(ByVal value As List(Of terrenoExpedienteDE))
            terrenosExpe = value
        End Set
    End Property
    Public Property consultoraObras() As consultoraObraDE
        Get
            Return consultoraObra
        End Get
        Set(ByVal value As consultoraObraDE)
            consultoraObra = value
        End Set
    End Property
    Public Property fRegistroExpediente() As Date
        Get
            Return fRegistroExpe
        End Get
        Set(ByVal value As Date)
            fRegistroExpe = value
        End Set
    End Property
    Public Property docOtros() As String
        Get
            Return otrosDoc
        End Get
        Set(ByVal value As String)
            otrosDoc = value
        End Set
    End Property
    Public Property docGestionRiesgos() As String
        Get
            Return gestion
        End Get
        Set(ByVal value As String)
            gestion = value
        End Set
    End Property
    Public Property docFormulasPoli() As String
        Get
            Return formulas
        End Get
        Set(ByVal value As String)
            formulas = value
        End Set
    End Property
    Public Property docAnalisis() As String
        Get
            Return analisis
        End Get
        Set(ByVal value As String)
            analisis = value
        End Set
    End Property
    Public Property fRegistroPresupuesto() As Date
        Get
            Return fRegistroPre
        End Get
        Set(ByVal value As Date)
            fRegistroPre = value
        End Set
    End Property

    Public Property fechaPresupuesto() As Date
        Get
            Return fPresupuesto
        End Get
        Set(ByVal value As Date)
            fPresupuesto = value
        End Set
    End Property
    Public Property presupuestObra() As Double
        Get
            Return presupuesto
        End Get
        Set(ByVal value As Double)
            presupuesto = value
        End Set
    End Property
    Public Property codigoExpediente() As Integer
        Get
            Return cExpediente
        End Get
        Set(ByVal value As Integer)
            cExpediente = value
        End Set
    End Property


    Public Property convocatoriaPublica() As convocatoriaPublicaDE
        Get
            Return convocatoria
        End Get
        Set(ByVal value As convocatoriaPublicaDE)
            convocatoria = value
        End Set
    End Property
End Class
