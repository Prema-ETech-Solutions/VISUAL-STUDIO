Public Class Form1
    Dim C As New Dtabase()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bst As BindingSource
        bst = C.Connect
        If bst Is Nothing Then
            MessageBox.Show("CONNECTED")
        Else

            Guna2DataGridView1.DataSource = bst
            Guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Guna2DataGridView1.RowTemplate.Height = 500
            Dim aaa As New DataGridViewImageColumn()
            aaa = Guna2DataGridView1.Columns(1)
            aaa.ImageLayout = DataGridViewImageCellLayout.Stretch


        End If

    End Sub



End Class
