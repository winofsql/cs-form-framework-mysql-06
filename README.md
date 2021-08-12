# cs-form-framework-mysql-06
新しい Form で一覧を表示してダブルクリックで参照
![image](https://user-images.githubusercontent.com/1501327/129149962-ae94a4a9-4eb2-47c4-9af6-6d567ff0a04e.png)
## Form2 呼び出し
```cs
private void button3_Click(object sender, EventArgs e)
{
    Form2 form2 = new Form2( this );
    DialogResult result = form2.ShowDialog();
    if (result == System.Windows.Forms.DialogResult.OK)
    {
        this.scode.Focus();
        button1_Click(null, null);
    }
    form2.Dispose();
}
```

![image](https://user-images.githubusercontent.com/1501327/129150025-666d7475-2f2e-4db8-8647-23a16a717aaf.png)
## Form1 へアクセス
```cs
private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
{
    int row = e.RowIndex;
    if ( row < 0 )
    {
        return;
    }
    int column = e.ColumnIndex;
    string text = dataGridView1.Rows[row].Cells["社員コード"].Value.ToString();

    form1.scode.Text = text;
    this.DialogResult = System.Windows.Forms.DialogResult.OK;
    this.Close();
}
```
