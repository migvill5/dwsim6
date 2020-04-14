﻿'    DWSIM Dynamics Library
'    Copyright 2020 Daniel Wagner O. de Medeiros
'
'    This file is part of DWSIM.
'
'    DWSIM is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    DWSIM is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with DWSIM.  If not, see <http://www.gnu.org/licenses/>.

Imports DWSIM.Interfaces

Public Class Integrator

    Implements Interfaces.IDynamicsIntegrator, ICustomXMLSerialization

    Public Property ID As String = "" Implements IDynamicsIntegrator.ID

    Public Property Description As String = "" Implements IDynamicsIntegrator.Description

    Public Property ShouldCalculateEquilibrium As Boolean Implements IDynamicsIntegrator.ShouldCalculateEquilibrium

    Public Property ShouldCalculatePressureFlow As Boolean Implements IDynamicsIntegrator.ShouldCalculatePressureFlow

    Public Property ShouldCalculateControl As Boolean Implements IDynamicsIntegrator.ShouldCalculateControl

    Public Property IntegrationStep As TimeSpan = New TimeSpan(0, 0, 5) Implements IDynamicsIntegrator.IntegrationStep

    Public Property Duration As TimeSpan = New TimeSpan(0, 10, 0) Implements IDynamicsIntegrator.Duration

    Public Property CurrentTime As Date = New Date() Implements IDynamicsIntegrator.CurrentTime

    Public Property CalculationRateEquilibrium As Integer = 1 Implements IDynamicsIntegrator.CalculationRateEquilibrium

    Public Property CalculationRatePressureFlow As Integer = 1 Implements IDynamicsIntegrator.CalculationRatePressureFlow

    Public Property CalculationRateControl As Integer = 1 Implements IDynamicsIntegrator.CalculationRateControl

    Public Property RealTime As Boolean = False Implements IDynamicsIntegrator.RealTime

    Public Property StoredSolutions As Dictionary(Of Integer, List(Of XElement)) = New Dictionary(Of Integer, List(Of XElement)) Implements IDynamicsIntegrator.StoredSolutions

    Public Function SaveData() As List(Of XElement) Implements ICustomXMLSerialization.SaveData
        Dim data = XMLSerializer.XMLSerializer.Serialize(Me)
        Dim e1 = New XElement("StoredSolutions")
        For Each kvp As KeyValuePair(Of Integer, List(Of XElement)) In StoredSolutions
            e1.Add(New XElement("Solution" + "_" + kvp.Key.ToString(Globalization.CultureInfo.InvariantCulture),
                                kvp.Value))
        Next
        data.Add(e1)
        Return data
    End Function

    Public Function LoadData(data As List(Of XElement)) As Boolean Implements ICustomXMLSerialization.LoadData
        XMLSerializer.XMLSerializer.Deserialize(Me, data)
        Dim elm As XElement = (From xel2 As XElement In data Select xel2 Where xel2.Name = "StoredSolutions").LastOrDefault
        If Not elm Is Nothing Then
            StoredSolutions = New Dictionary(Of Integer, List(Of XElement))
            For Each xel2 As XElement In elm.Elements
                Try
                    StoredSolutions.Add(Integer.Parse(xel2.Name.LocalName.Split("_")(1), Globalization.CultureInfo.InvariantCulture),
                                    xel2.Elements.ToList)
                Catch ex As Exception
                End Try
            Next
        End If
        Return True
    End Function

End Class
