
namespace cs_form_mysql_06
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.sname = new System.Windows.Forms.TextBox();
            this.scode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.syozoku = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "実行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(252, 121);
            this.sname.Margin = new System.Windows.Forms.Padding(5);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(349, 26);
            this.sname.TabIndex = 1;
            // 
            // scode
            // 
            this.scode.Location = new System.Drawing.Point(252, 65);
            this.scode.Margin = new System.Windows.Forms.Padding(5);
            this.scode.Name = "scode";
            this.scode.Size = new System.Drawing.Size(112, 26);
            this.scode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "社員コード";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "氏名";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "更新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(286, 448);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(168, 33);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "性別";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 27);
            this.comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "所属";
            // 
            // syozoku
            // 
            this.syozoku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syozoku.FormattingEnabled = true;
            this.syozoku.Location = new System.Drawing.Point(252, 228);
            this.syozoku.Name = "syozoku";
            this.syozoku.Size = new System.Drawing.Size(185, 27);
            this.syozoku.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "参照";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.syozoku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scode);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社員マスタメンテ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox syozoku;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox scode;
    }
}

