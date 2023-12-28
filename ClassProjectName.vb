Public Class ClassProjectName
    Public Property FirstName() As String
        Get
            Return m_FirstName
        End Get
        Set(value As String)
            m_FirstName = value
        End Set
    End Property
    Private m_FirstName As String
        Public Property LastName() As String
            Get
                Return m_LastName
            End Get
            Set(value As String)
                m_LastName = value
            End Set
        End Property
        Private m_LastName As String
        Public Property Occupation() As String
            Get
                Return m_Occupation
            End Get
            Set(value As String)
                m_Occupation = value
            End Set
        End Property
        Private m_Occupation As String
        Public Property StartingDate() As DateTime
            Get
                Return m_StartingDate
            End Get
            Set(value As DateTime)
                m_StartingDate = value
            End Set
        End Property
        Private m_StartingDate As DateTime
        Public Property IsMarried() As Boolean
            Get
                Return m_IsMarried
            End Get
            Set(value As Boolean)
                m_IsMarried = value
            End Set
        End Property
        Private m_IsMarried As Boolean

End Class
