﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Strings
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DWSIM.UnitOperations.Strings", GetType(Strings).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Bloco lógico para controle de variáveis.
        '''</summary>
        Friend Shared ReadOnly Property ADJ_Desc() As String
            Get
                Return ResourceManager.GetString("ADJ_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Controlador.
        '''</summary>
        Friend Shared ReadOnly Property ADJ_Name() As String
            Get
                Return ResourceManager.GetString("ADJ_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo para simulação rigorosa de colunas de absorção.
        '''</summary>
        Friend Shared ReadOnly Property CABS_Desc() As String
            Get
                Return ResourceManager.GetString("CABS_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Coluna de Absorção.
        '''</summary>
        Friend Shared ReadOnly Property CABS_Name() As String
            Get
                Return ResourceManager.GetString("CABS_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo rigoroso para simulação de colunas de destilação.
        '''</summary>
        Friend Shared ReadOnly Property CDEST_Desc() As String
            Get
                Return ResourceManager.GetString("CDEST_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Coluna de Destilação.
        '''</summary>
        Friend Shared ReadOnly Property CDEST_Name() As String
            Get
                Return ResourceManager.GetString("CDEST_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo para um compressor isentrópico.
        '''</summary>
        Friend Shared ReadOnly Property COMP_Desc() As String
            Get
                Return ResourceManager.GetString("COMP_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Compressor Adiabático.
        '''</summary>
        Friend Shared ReadOnly Property COMP_Name() As String
            Get
                Return ResourceManager.GetString("COMP_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Suporta reações definidas por uma taxa de conversão de reagentes.
        '''</summary>
        Friend Shared ReadOnly Property CONV_Desc() As String
            Get
                Return ResourceManager.GetString("CONV_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reator de Conversão.
        '''</summary>
        Friend Shared ReadOnly Property CONV_Name() As String
            Get
                Return ResourceManager.GetString("CONV_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo de resfriador simples.
        '''</summary>
        Friend Shared ReadOnly Property COOL_Desc() As String
            Get
                Return ResourceManager.GetString("COOL_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Resfriador.
        '''</summary>
        Friend Shared ReadOnly Property COOL_Name() As String
            Get
                Return ResourceManager.GetString("COOL_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo para simulação de operações unitárias CAPE-OPEN.
        '''</summary>
        Friend Shared ReadOnly Property COUO_Desc() As String
            Get
                Return ResourceManager.GetString("COUO_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Operação Unitária CAPE-OPEN.
        '''</summary>
        Friend Shared ReadOnly Property COUO_Name() As String
            Get
                Return ResourceManager.GetString("COUO_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo rigoroso de absorvedora com refervedor.
        '''</summary>
        Friend Shared ReadOnly Property CRABS_Desc() As String
            Get
                Return ResourceManager.GetString("CRABS_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Absorvedora com Refervedor.
        '''</summary>
        Friend Shared ReadOnly Property CRABS_Name() As String
            Get
                Return ResourceManager.GetString("CRABS_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo rigoroso de uma coluna de absorção com refluxo.
        '''</summary>
        Friend Shared ReadOnly Property CRFABS_Desc() As String
            Get
                Return ResourceManager.GetString("CRFABS_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Absorvedora com Refluxo.
        '''</summary>
        Friend Shared ReadOnly Property CRFABS_Name() As String
            Get
                Return ResourceManager.GetString("CRFABS_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo para dimensionamento rápido de colunas de destilação.
        '''</summary>
        Friend Shared ReadOnly Property CSC_Desc() As String
            Get
                Return ResourceManager.GetString("CSC_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Coluna Shortcut.
        '''</summary>
        Friend Shared ReadOnly Property CSC_Name() As String
            Get
                Return ResourceManager.GetString("CSC_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo para separação hipotética de substâncias.
        '''</summary>
        Friend Shared ReadOnly Property CSEP_Desc() As String
            Get
                Return ResourceManager.GetString("CSEP_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Separador de Substâncias.
        '''</summary>
        Friend Shared ReadOnly Property CSEP_Name() As String
            Get
                Return ResourceManager.GetString("CSEP_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo de um CSTR, suporta reações Cinéticas e Catalíticas Heterogêneas.
        '''</summary>
        Friend Shared ReadOnly Property CSTR_Desc() As String
            Get
                Return ResourceManager.GetString("CSTR_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reator Tanque Continuamente Agitado (CSTR).
        '''</summary>
        Friend Shared ReadOnly Property CSTR_Name() As String
            Get
                Return ResourceManager.GetString("CSTR_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Suporta reações definidas por constantes de equilíbrio.
        '''</summary>
        Friend Shared ReadOnly Property EQUIL_Desc() As String
            Get
                Return ResourceManager.GetString("EQUIL_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reator de Equilíbrio.
        '''</summary>
        Friend Shared ReadOnly Property EQUIL_Name() As String
            Get
                Return ResourceManager.GetString("EQUIL_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Bloco lógico para reciclo de correntes de energia.
        '''</summary>
        Friend Shared ReadOnly Property ERECY_Desc() As String
            Get
                Return ResourceManager.GetString("ERECY_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reciclo de Energia.
        '''</summary>
        Friend Shared ReadOnly Property ERECY_Name() As String
            Get
                Return ResourceManager.GetString("ERECY_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Representa o fluxo de energia entrando e saindo das operações unitárias.
        '''</summary>
        Friend Shared ReadOnly Property ESTR_Desc() As String
            Get
                Return ResourceManager.GetString("ESTR_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Corrente de Energia.
        '''</summary>
        Friend Shared ReadOnly Property ESTR_Name() As String
            Get
                Return ResourceManager.GetString("ESTR_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo para utilização de uma planilha como um bloco no fluxograma.
        '''</summary>
        Friend Shared ReadOnly Property EXLUO_Desc() As String
            Get
                Return ResourceManager.GetString("EXLUO_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Planilha.
        '''</summary>
        Friend Shared ReadOnly Property EXLUO_Name() As String
            Get
                Return ResourceManager.GetString("EXLUO_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo para um expansor isentrópico.
        '''</summary>
        Friend Shared ReadOnly Property EXP_Desc() As String
            Get
                Return ResourceManager.GetString("EXP_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Expansor Adiabático.
        '''</summary>
        Friend Shared ReadOnly Property EXP_Name() As String
            Get
                Return ResourceManager.GetString("EXP_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo de filtro de sólidos.
        '''</summary>
        Friend Shared ReadOnly Property FILTER_Desc() As String
            Get
                Return ResourceManager.GetString("FILTER_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Filtro.
        '''</summary>
        Friend Shared ReadOnly Property FILTER_Name() As String
            Get
                Return ResourceManager.GetString("FILTER_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo para utilização de uma simulação existente como um bloco no fluxograma.
        '''</summary>
        Friend Shared ReadOnly Property FLOWS_Desc() As String
            Get
                Return ResourceManager.GetString("FLOWS_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fluxograma.
        '''</summary>
        Friend Shared ReadOnly Property FLOWS_Name() As String
            Get
                Return ResourceManager.GetString("FLOWS_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Calcula o equilíbrio químico de átomos em uma Corrente de Matéria.
        '''</summary>
        Friend Shared ReadOnly Property GIBBS_Desc() As String
            Get
                Return ResourceManager.GetString("GIBBS_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reator de Gibbs.
        '''</summary>
        Friend Shared ReadOnly Property GIBBS_Name() As String
            Get
                Return ResourceManager.GetString("GIBBS_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo de aquecedor simples.
        '''</summary>
        Friend Shared ReadOnly Property HEAT_Desc() As String
            Get
                Return ResourceManager.GetString("HEAT_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Aquecedor.
        '''</summary>
        Friend Shared ReadOnly Property HEAT_Name() As String
            Get
                Return ResourceManager.GetString("HEAT_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo de trocador de calor rigoroso.
        '''</summary>
        Friend Shared ReadOnly Property HEXCH_Desc() As String
            Get
                Return ResourceManager.GetString("HEXCH_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Trocador de Calor Rigoroso.
        '''</summary>
        Friend Shared ReadOnly Property HEXCH_Name() As String
            Get
                Return ResourceManager.GetString("HEXCH_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Operação unitária definida por um script Python.
        '''</summary>
        Friend Shared ReadOnly Property IPUO_Desc() As String
            Get
                Return ResourceManager.GetString("IPUO_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Script Python.
        '''</summary>
        Friend Shared ReadOnly Property IPUO_Name() As String
            Get
                Return ResourceManager.GetString("IPUO_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Mistura múltiplas Correntes de Matéria em uma.
        '''</summary>
        Friend Shared ReadOnly Property MIX_Desc() As String
            Get
                Return ResourceManager.GetString("MIX_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Misturador de Correntes.
        '''</summary>
        Friend Shared ReadOnly Property MIX_Name() As String
            Get
                Return ResourceManager.GetString("MIX_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Bloco para conexão de Correntes de Matéria de corte.
        '''</summary>
        Friend Shared ReadOnly Property MRECY_Desc() As String
            Get
                Return ResourceManager.GetString("MRECY_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reciclo.
        '''</summary>
        Friend Shared ReadOnly Property MRECY_Name() As String
            Get
                Return ResourceManager.GetString("MRECY_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dimensiona ou avalia uma placa de orifício.
        '''</summary>
        Friend Shared ReadOnly Property ORIF_Desc() As String
            Get
                Return ResourceManager.GetString("ORIF_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Placa de Orifício.
        '''</summary>
        Friend Shared ReadOnly Property ORIF_Name() As String
            Get
                Return ResourceManager.GetString("ORIF_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo de um PFR, suporta reações Cinéticas e Catalíticas Heterogêneas.
        '''</summary>
        Friend Shared ReadOnly Property PFR_Desc() As String
            Get
                Return ResourceManager.GetString("PFR_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reator Plug-Flow (PFR).
        '''</summary>
        Friend Shared ReadOnly Property PFR_Name() As String
            Get
                Return ResourceManager.GetString("PFR_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Define um segmento de tubulação e acessórios para cálculo de perda de carga.
        '''</summary>
        Friend Shared ReadOnly Property PIPE_Desc() As String
            Get
                Return ResourceManager.GetString("PIPE_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Segmento de Tubulação.
        '''</summary>
        Friend Shared ReadOnly Property PIPE_Name() As String
            Get
                Return ResourceManager.GetString("PIPE_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo de bomba centrífuga.
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Desc() As String
            Get
                Return ResourceManager.GetString("PUMP_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Nenhum tipo de bomba definido!.
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Err1() As String
            Get
                Return ResourceManager.GetString("PUMP_Err1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Banco de dados já existe!.
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Err2() As String
            Get
                Return ResourceManager.GetString("PUMP_Err2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Banco de dados não encontrado!.
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Err3() As String
            Get
                Return ResourceManager.GetString("PUMP_Err3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modificada.
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Modified() As String
            Get
                Return ResourceManager.GetString("PUMP_Modified", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  criado..
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Msg1() As String
            Get
                Return ResourceManager.GetString("PUMP_Msg1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Substituir ?.
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Msg2() As String
            Get
                Return ResourceManager.GetString("PUMP_Msg2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Bomba Centrífuga.
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Name() As String
            Get
                Return ResourceManager.GetString("PUMP_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Salvo.
        '''</summary>
        Friend Shared ReadOnly Property PUMP_Saved() As String
            Get
                Return ResourceManager.GetString("PUMP_Saved", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Define uma variável como função de outra.
        '''</summary>
        Friend Shared ReadOnly Property SPEC_Desc() As String
            Get
                Return ResourceManager.GetString("SPEC_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Especificação.
        '''</summary>
        Friend Shared ReadOnly Property SPEC_Name() As String
            Get
                Return ResourceManager.GetString("SPEC_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Divide uma Corrente de Matéria em outras correntes.
        '''</summary>
        Friend Shared ReadOnly Property SPLIT_Desc() As String
            Get
                Return ResourceManager.GetString("SPLIT_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Divisor de Correntes.
        '''</summary>
        Friend Shared ReadOnly Property SPLIT_Name() As String
            Get
                Return ResourceManager.GetString("SPLIT_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Separa a fase sólida das demais em uma Corrente de Matéria.
        '''</summary>
        Friend Shared ReadOnly Property SSEP_Desc() As String
            Get
                Return ResourceManager.GetString("SSEP_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Separador de Sólidos.
        '''</summary>
        Friend Shared ReadOnly Property SSEP_Name() As String
            Get
                Return ResourceManager.GetString("SSEP_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo simplificado de tanque de armazenamento.
        '''</summary>
        Friend Shared ReadOnly Property TANK_Desc() As String
            Get
                Return ResourceManager.GetString("TANK_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tanque.
        '''</summary>
        Friend Shared ReadOnly Property TANK_Name() As String
            Get
                Return ResourceManager.GetString("TANK_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modelo de válvula com expansão isentálpica.
        '''</summary>
        Friend Shared ReadOnly Property VALVE_Desc() As String
            Get
                Return ResourceManager.GetString("VALVE_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Válvula.
        '''</summary>
        Friend Shared ReadOnly Property VALVE_Name() As String
            Get
                Return ResourceManager.GetString("VALVE_Name", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Separador de fases fluidas (vapor/líquido).
        '''</summary>
        Friend Shared ReadOnly Property VESSEL_Desc() As String
            Get
                Return ResourceManager.GetString("VESSEL_Desc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Vaso Separador Gás-Líquido.
        '''</summary>
        Friend Shared ReadOnly Property VESSEL_Name() As String
            Get
                Return ResourceManager.GetString("VESSEL_Name", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
