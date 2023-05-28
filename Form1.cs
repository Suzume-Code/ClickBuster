using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickBuster_cs
{
    public partial class F_Menu : Form
    {
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button B_Syokyu;
        private System.Windows.Forms.Button B_Chukyu;
        private System.Windows.Forms.Button B_Jyokyu;
        private System.Windows.Forms.Button B_Close;

        public F_Menu()
        {
            //InitializeComponent();
            this.B_Syokyu = new System.Windows.Forms.Button();
            this.B_Chukyu = new System.Windows.Forms.Button();
            this.B_Jyokyu = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Syokyu
            // 
            this.B_Syokyu.Location = new System.Drawing.Point(20, 18);
            this.B_Syokyu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.B_Syokyu.Name = "B_Syokyu";
            this.B_Syokyu.Size = new System.Drawing.Size(433, 111);
            this.B_Syokyu.TabIndex = 0;
            this.B_Syokyu.Text = "初級";
            this.B_Syokyu.UseVisualStyleBackColor = true;
            this.B_Syokyu.Click += new System.EventHandler(this.B_Syokyu_Click);
            // 
            // B_Chukyu
            // 
            this.B_Chukyu.Location = new System.Drawing.Point(20, 138);
            this.B_Chukyu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.B_Chukyu.Name = "B_Chukyu";
            this.B_Chukyu.Size = new System.Drawing.Size(433, 111);
            this.B_Chukyu.TabIndex = 1;
            this.B_Chukyu.Text = "中級";
            this.B_Chukyu.UseVisualStyleBackColor = true;
            this.B_Chukyu.Click += new System.EventHandler(this.B_Chukyu_Click);
            // 
            // B_Jyokyu
            // 
            this.B_Jyokyu.Location = new System.Drawing.Point(20, 258);
            this.B_Jyokyu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.B_Jyokyu.Name = "B_Jyokyu";
            this.B_Jyokyu.Size = new System.Drawing.Size(433, 111);
            this.B_Jyokyu.TabIndex = 2;
            this.B_Jyokyu.Text = "上級";
            this.B_Jyokyu.UseVisualStyleBackColor = true;
            this.B_Jyokyu.Click += new System.EventHandler(this.B_Jyokyu_Click);
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(20, 412);
            this.B_Close.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(433, 111);
            this.B_Close.TabIndex = 3;
            this.B_Close.Text = "終了";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 542);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Jyokyu);
            this.Controls.Add(this.B_Chukyu);
            this.Controls.Add(this.B_Syokyu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickBuster (メニュー画面)";
            this.ResumeLayout(false);
        }

        /// <summary>
        /// 初級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Syokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 400,    // フォームの高さ
                Width = 400,     // フォームの幅
                EnmTim = 1000,   // 敵の動く速度
                Enms = 20,       // 敵の数
                GmTim = 10000    // 制限時間
            };

            // 難易度初期化
            fMain.FrmIni();

            fMain.Show(this);
            Hide();
        }

        /// <summary>
        /// 中級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Chukyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 500,    // フォームの高さ
                Width = 700,     // フォームの幅
                EnmTim = 800,    // 敵の動く速度
                Enms = 30,       // 敵の数
                GmTim = 15000    // 制限時間
            };

            // 難易度初期化
            fMain.FrmIni();

            // thisを指定することにより、子フォームに親フォームを設定
            fMain.Show(this);
            Hide();
        }

        /// <summary>
        /// 上級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Jyokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 600,    // フォームの高さ
                Width = 800,     // フォームの幅
                EnmTim = 300,    // 敵の動く速度
                Enms = 40,       // 敵の数
                GmTim = 20000    // 制限時間
            };

            // 難易度初期化
            fMain.FrmIni();

            // thisを指定することにより、子フォームに親フォームを設定
            fMain.Show(this);
            Hide();
        }

        /// <summary>
        /// 終了ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Close_Click(object sender, EventArgs e)
        {
            Close();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
