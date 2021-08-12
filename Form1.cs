using System;
using System.Data.Odbc;
using System.Diagnostics;
using System.Windows.Forms;

namespace cs_form_framework_mysql_06
{
    public partial class Form1 : Form
    {
        private int kaiwa = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection myCon = CreateConnection();

            // MySQL の処理

            string target = this.scode.Text;

            // SQL
            string myQuery =
                $@"SELECT
                    社員マスタ.*,
                    DATE_FORMAT(生年月日,'%Y-%m-%d') as 誕生日
                    from 社員マスタ
                    where 社員コード = '{target}'";

            // SQL実行用のオブジェクトを作成
            OdbcCommand myCommand = new OdbcCommand();

            // 実行用オブジェクトに必要な情報を与える
            myCommand.CommandText = myQuery;    // SQL
            myCommand.Connection = myCon;       // 接続

            // 次でする、データベースの値をもらう為のオブジェクトの変数の定義
            OdbcDataReader myReader;

            // SELECT を実行した結果を取得
            myReader = myCommand.ExecuteReader();

            // myReader からデータが読みだされる間ずっとループ
            if (myReader.Read())
            {
                string text = getDbText(myReader, "氏名");

                // 性別コンボボックスのデータセット
                int seibetu = getDbInt(myReader,"性別");
                //this.comboBox1.SelectedIndex = seibetu;


                // 内部データとデータベースデータの比較
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    ComboData cd = (ComboData)comboBox1.Items[i];
                    if (cd.Data == $"{seibetu}")
                    {
                        this.comboBox1.SelectedIndex = i;
                    }
                }

                // 所属コンボボックスのデータセット
                string syozoku = getDbText(myReader,"所属");

                // 所属データとデータベースデータの比較
                for (int i = 0; i < this.syozoku.Items.Count; i++)
                {
                    ComboData cd = (ComboData)this.syozoku.Items[i];
                    if (cd.Data == $"{syozoku}")
                    {
                        this.syozoku.SelectedIndex = i;
                    }
                }




                // 出力ウインドウに出力
                Debug.WriteLine($"Debug:{text}");

                this.sname.Text = text;
                this.button1.Text = "送信";

            }

            myReader.Close();

            myCon.Close();

            // 第二会話に移行
            kaiwa = 2;
            Form1_Load(null, null);

        }

        private OdbcConnection CreateConnection()
        {
            // 接続文字列の作成
            OdbcConnectionStringBuilder builder = new OdbcConnectionStringBuilder();
            builder.Driver = "MySQL ODBC 8.0 Unicode Driver";
            // 接続用のパラメータを追加
            builder.Add("server", "localhost");
            builder.Add("database", "lightbox");
            builder.Add("uid", "root");
            builder.Add("pwd", "");

            string work = builder.ConnectionString;

            Console.WriteLine(builder.ConnectionString);

            // 接続の作成
            OdbcConnection myCon = new OdbcConnection();

            // MySQL の接続準備完了
            myCon.ConnectionString = builder.ConnectionString;

            // MySQL に接続
            myCon.Open();

            return myCon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("更新しますか?", "確認", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return;
            }

            // 更新処理
            OdbcConnection myCon = CreateConnection();

            // MySQL の処理

            string target = this.scode.Text;
            string sname = this.sname.Text;

            // 選択された ComboData を取得して、内部のコードを取得して SQL に使う
            ComboData cd = (ComboData)comboBox1.SelectedItem;
            string seibetu = cd.Data;

            // 選択された ComboData を取得して、内部のコードを取得して SQL に使う
            cd = (ComboData)this.syozoku.SelectedItem;
            string syozoku = cd.Data;

            // SQL
            string myQuery =
                $@"UPDATE 社員マスタ
                    SET 氏名 = '{sname}',
                        性別 = {seibetu},
                        所属 = '{syozoku}'
                    where 社員コード = '{target}'";

            // SQL実行用のオブジェクトを作成
            OdbcCommand myCommand = new OdbcCommand();

            // 実行用オブジェクトに必要な情報を与える
            myCommand.CommandText = myQuery;    // SQL
            myCommand.Connection = myCon;       // 接続

            myCommand.ExecuteNonQuery();

            myCon.Close();

            clearForm();

        }

        private void clearForm()
        {
            scode.Clear();
            sname.Clear();
            comboBox1.SelectedIndex = -1;
            syozoku.SelectedIndex = -1;

            // 第一会話に移行
            kaiwa = 1;
            Form1_Load(null, null);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (sender != null)
            {
                // ComboData を コンボボックスにセット
                comboBox1.Items.Clear();
                comboBox1.Items.Add(new ComboData("男性", "0"));
                comboBox1.Items.Add(new ComboData("女性", "1"));
                // 非選択状態
                comboBox1.SelectedIndex = -1;


                //所属コンボボックスの作成
                OdbcConnection myCon = CreateConnection();
                // SQL
                string myQuery =
                    $@"SELECT
                        *
                    from コード名称マスタ
                    where 区分 = '2'
                    order by コード";
                // SQL実行用のオブジェクトを作成
                OdbcCommand myCommand = new OdbcCommand();

                // 実行用オブジェクトに必要な情報を与える
                myCommand.CommandText = myQuery;    // SQL
                myCommand.Connection = myCon;       // 接続

                // 次でする、データベースの値をもらう為のオブジェクトの変数の定義
                OdbcDataReader myReader;

                // SELECT を実行した結果を取得
                myReader = myCommand.ExecuteReader();

                syozoku.Items.Clear();
                // myReader からデータが読みだされる間ずっとループ
                while (myReader.Read())
                {
                    string text = getDbText(myReader,"名称");
                    string data = getDbText(myReader, "コード");

                    syozoku.Items.Add(new ComboData(text,data));
                }
                // 非選択状態
                comboBox1.SelectedIndex = -1;
                
                myReader.Close();

                myCon.Close();

            }

            // 初期状態
            if ( kaiwa == 1 )
            {
                scode.Enabled = true;
                button1.Enabled = true;

                sname.Enabled = false;
                comboBox1.Enabled = false;
                syozoku.Enabled = false;
                button2.Enabled = false;
                cancel.Enabled = false;
            }
            // 第二会話
            if (kaiwa == 2)
            {
                scode.Enabled = false;
                button1.Enabled = false;

                sname.Enabled = true;
                comboBox1.Enabled = true;
                syozoku.Enabled = true;
                button2.Enabled = true;
                cancel.Enabled = true;
            }
        }

        private string getDbText(OdbcDataReader myReader, string v)
        {
            int index = myReader.GetOrdinal(v);
            // 列番号で、値を取得して文字列化
            string text = myReader.GetValue(index).ToString();

            return text;

        }
        private int getDbInt(OdbcDataReader myReader, string v)
        {
            int index = myReader.GetOrdinal(v);
            // 列番号で、値を取得して文字列化
            int data = myReader.GetInt16(index);

            return data;

        }

        private void cancel_Click(object sender, EventArgs e)
        {

            clearForm();

        }

        // ******************************
        // コンボボックスに追加情報
        // をセットする為のクラス
        // ******************************
        private class ComboData
        {

            public ComboData(string Text, string Data)
            {
                this.Text = Text;
                this.Data = Data;
            }

            public string Text { get; set; }
            public string Data { get; set; }

            public override string ToString()
            {
                return this.Text;
            }
        }

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
    }
}
