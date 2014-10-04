Imports System.IO
Imports System.Xml
Module xml_read
    Sub file_data_xml(ByVal filename As String, ByRef file_data(,) As String)
        Dim i = 0
        Dim m_xmlr As XmlTextReader
        'Create the XML Reader
        m_xmlr = New XmlTextReader(filename)
        'Disable whitespace so that you don't have to read over whitespaces
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        'read the xml declaration and advance to family tag
        m_xmlr.Read()
        'read the family tag
        m_xmlr.Read()
        m_xmlr.Read()
        'read version
        file_data(3, 0) = m_xmlr.GetAttribute("ver").ToString
        'Load the Loop
        While Not m_xmlr.EOF
            'Go to the name tag
            m_xmlr.Read()

            'if not start element exit while loop
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            'Get the Gender Attribute Value
            'Dim genderAttribute = m_xmlr.GetAttribute("time")
            'Read elements firstname and lastname

            m_xmlr.Read()
            file_data(0, i) = m_xmlr.ReadElementString("path")
            file_data(1, i) = m_xmlr.ReadElementString("name")
            file_data(2, i) = m_xmlr.ReadElementString("md5")

            'MsgBox(genderAttribute)
            'Write Result to the Console
            'MsgBox("Gender: " & genderAttribute _
            '  & " filename: " & file_data(0, i) & " md5: " _
            '  & file_data(1, i))
            i = i + 1
        End While
        'close the reader
        m_xmlr.Close()
    End Sub

End Module
