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
