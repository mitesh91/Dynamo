﻿Imports System.Dynamic
Imports System.Collections.ObjectModel

Namespace Entities
    Public Interface IEntity
        Property Id As Object
        Property Name As String
        Property Fields As Dictionary(Of String, Object)
        'Property Fields As DataRow
        Property Schema As EntitySchema
    End Interface

    Public Class Entity
        Implements IEntity
        Public Property Id As Object Implements IEntity.Id
        Public Property Name As String Implements IEntity.Name
        Public Property Fields As Dictionary(Of String, Object) Implements IEntity.Fields
        'Public Property Fields As DataRow Implements IEntity.Fields
        Public Property Schema As EntitySchema Implements IEntity.Schema

        Sub New()
            Fields = New Dictionary(Of String, Object)
            Schema = New EntitySchema
        End Sub
    End Class

    Public Class EntityRelationShip
        Public Property ForeignKeyName As String
        Public Property EntityName As String
        Public Property FieldName As String
        Public Property PrimaryEntityName As String
        Public Property PrimaryFieldName As String
    End Class

    Public Class EntitySchema
        Public Property PrimaryKeys As ReadOnlyDictionary(Of String, Object)
        Public Property EntityObjectName As String
        Public Property EntityFieldID As String
        Public Property EntityFieldName As String
    End Class

End Namespace