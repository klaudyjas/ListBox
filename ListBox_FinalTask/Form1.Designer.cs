
namespace ListBox_FinalTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_dodajz = new System.Windows.Forms.Button();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.btn_edytujz = new System.Windows.Forms.Button();
            this.btn_usunw = new System.Windows.Forms.Button();
            this.btn_usunz = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelZ = new System.Windows.Forms.Panel();
            this.txt_z = new System.Windows.Forms.TextBox();
            this.btn_x = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.panelBtns.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelZ.SuspendLayout();
            this.panelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.SystemColors.InfoText;
            this.input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.input.Location = new System.Drawing.Point(1058, 1519);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(244, 27);
            this.input.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2124, 1303);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(156, 150);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btn_dodajz
            // 
            this.btn_dodajz.BackColor = System.Drawing.SystemColors.Info;
            this.btn_dodajz.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dodajz.Location = new System.Drawing.Point(59, 30);
            this.btn_dodajz.Name = "btn_dodajz";
            this.btn_dodajz.Size = new System.Drawing.Size(163, 29);
            this.btn_dodajz.TabIndex = 6;
            this.btn_dodajz.Text = "Dodaj zadanie";
            this.btn_dodajz.UseVisualStyleBackColor = false;
            this.btn_dodajz.Click += new System.EventHandler(this.btn_dodajz_Click);
            // 
            // panelBtns
            // 
            this.panelBtns.Controls.Add(this.btn_edytujz);
            this.panelBtns.Controls.Add(this.btn_usunw);
            this.panelBtns.Controls.Add(this.btn_usunz);
            this.panelBtns.Controls.Add(this.btn_dodajz);
            this.panelBtns.Location = new System.Drawing.Point(442, 40);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(263, 318);
            this.panelBtns.TabIndex = 8;
            // 
            // btn_edytujz
            // 
            this.btn_edytujz.BackColor = System.Drawing.SystemColors.Info;
            this.btn_edytujz.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edytujz.Location = new System.Drawing.Point(55, 91);
            this.btn_edytujz.Name = "btn_edytujz";
            this.btn_edytujz.Size = new System.Drawing.Size(167, 29);
            this.btn_edytujz.TabIndex = 9;
            this.btn_edytujz.Text = "Edytuj zadanie";
            this.btn_edytujz.UseVisualStyleBackColor = false;
            this.btn_edytujz.Click += new System.EventHandler(this.btn_edytujz_Click);
            // 
            // btn_usunw
            // 
            this.btn_usunw.BackColor = System.Drawing.SystemColors.Info;
            this.btn_usunw.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_usunw.Location = new System.Drawing.Point(55, 227);
            this.btn_usunw.Name = "btn_usunw";
            this.btn_usunw.Size = new System.Drawing.Size(167, 29);
            this.btn_usunw.TabIndex = 8;
            this.btn_usunw.Text = "Usuń wszystko";
            this.btn_usunw.UseVisualStyleBackColor = false;
            this.btn_usunw.Click += new System.EventHandler(this.btn_usunw_Click);
            // 
            // btn_usunz
            // 
            this.btn_usunz.BackColor = System.Drawing.SystemColors.Info;
            this.btn_usunz.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_usunz.Location = new System.Drawing.Point(55, 158);
            this.btn_usunz.Name = "btn_usunz";
            this.btn_usunz.Size = new System.Drawing.Size(167, 29);
            this.btn_usunz.TabIndex = 7;
            this.btn_usunz.Text = "Usuń zadanie";
            this.btn_usunz.UseVisualStyleBackColor = false;
            this.btn_usunz.Click += new System.EventHandler(this.btn_usunz_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.panelZ);
            this.panel3.Controls.Add(this.panelList);
            this.panel3.Controls.Add(this.panelBtns);
            this.panel3.Location = new System.Drawing.Point(12, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 402);
            this.panel3.TabIndex = 9;
            // 
            // panelZ
            // 
            this.panelZ.Controls.Add(this.txt_z);
            this.panelZ.Controls.Add(this.btn_x);
            this.panelZ.Controls.Add(this.label1);
            this.panelZ.Controls.Add(this.btn_ok);
            this.panelZ.Location = new System.Drawing.Point(34, 42);
            this.panelZ.Name = "panelZ";
            this.panelZ.Size = new System.Drawing.Size(389, 77);
            this.panelZ.TabIndex = 10;
            this.panelZ.Visible = false;
            // 
            // txt_z
            // 
            this.txt_z.Location = new System.Drawing.Point(11, 42);
            this.txt_z.Multiline = true;
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(251, 29);
            this.txt_z.TabIndex = 9;
            // 
            // btn_x
            // 
            this.btn_x.BackColor = System.Drawing.SystemColors.Info;
            this.btn_x.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_x.Location = new System.Drawing.Point(345, 42);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(30, 29);
            this.btn_x.TabIndex = 6;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista zadań do wykonania na dziś:";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ok.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ok.Location = new System.Drawing.Point(290, 42);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(48, 29);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.textBox1);
            this.panelList.Controls.Add(this.listbox);
            this.panelList.Location = new System.Drawing.Point(34, 128);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(389, 230);
            this.panelList.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(880, 1383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 27);
            this.textBox1.TabIndex = 8;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 20;
            this.listbox.Location = new System.Drawing.Point(0, 0);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(389, 224);
            this.listbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBtns.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelZ.ResumeLayout(false);
            this.panelZ.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_dodajz;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_usunw;
        private System.Windows.Forms.Button btn_usunz;
        private System.Windows.Forms.TextBox txt_z;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_edytujz;
        private System.Windows.Forms.Panel panelZ;
    }
}

