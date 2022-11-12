namespace Cgm23
{
    partial class MainForm
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DataText = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxAs01 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs02 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs24 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.checkBoxAs03 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs09 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs11 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs12 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs13 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs14 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs15 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs21 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs22 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs23 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs25 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweIndexMakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.AantalCharts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataText
            // 
            this.DataText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataText.Location = new System.Drawing.Point(12, 35);
            this.DataText.Multiline = true;
            this.DataText.Name = "DataText";
            this.DataText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DataText.Size = new System.Drawing.Size(635, 512);
            this.DataText.TabIndex = 1;
            // 
            // checkBoxAs01
            // 
            this.checkBoxAs01.AutoSize = true;
            this.checkBoxAs01.Checked = true;
            this.checkBoxAs01.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs01.Location = new System.Drawing.Point(679, 35);
            this.checkBoxAs01.Name = "checkBoxAs01";
            this.checkBoxAs01.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs01.TabIndex = 3;
            this.checkBoxAs01.Text = "As01";
            this.checkBoxAs01.UseVisualStyleBackColor = true;
            this.checkBoxAs01.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs02
            // 
            this.checkBoxAs02.AutoSize = true;
            this.checkBoxAs02.Checked = true;
            this.checkBoxAs02.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs02.Location = new System.Drawing.Point(679, 63);
            this.checkBoxAs02.Name = "checkBoxAs02";
            this.checkBoxAs02.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs02.TabIndex = 4;
            this.checkBoxAs02.Text = "As02";
            this.checkBoxAs02.UseVisualStyleBackColor = true;
            this.checkBoxAs02.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs24
            // 
            this.checkBoxAs24.AutoSize = true;
            this.checkBoxAs24.Checked = true;
            this.checkBoxAs24.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs24.Location = new System.Drawing.Point(842, 119);
            this.checkBoxAs24.Name = "checkBoxAs24";
            this.checkBoxAs24.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs24.TabIndex = 5;
            this.checkBoxAs24.Text = "As24";
            this.checkBoxAs24.UseVisualStyleBackColor = true;
            this.checkBoxAs24.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(679, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilter.Location = new System.Drawing.Point(679, 425);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(366, 26);
            this.textBoxFilter.TabIndex = 8;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFilter.Location = new System.Drawing.Point(679, 501);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(366, 38);
            this.buttonClearFilter.TabIndex = 9;
            this.buttonClearFilter.Text = "Filter Clear";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // checkBoxAs03
            // 
            this.checkBoxAs03.AutoSize = true;
            this.checkBoxAs03.Checked = true;
            this.checkBoxAs03.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs03.Location = new System.Drawing.Point(679, 91);
            this.checkBoxAs03.Name = "checkBoxAs03";
            this.checkBoxAs03.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs03.TabIndex = 12;
            this.checkBoxAs03.Text = "As03";
            this.checkBoxAs03.UseVisualStyleBackColor = true;
            this.checkBoxAs03.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs09
            // 
            this.checkBoxAs09.AutoSize = true;
            this.checkBoxAs09.Checked = true;
            this.checkBoxAs09.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs09.Location = new System.Drawing.Point(679, 119);
            this.checkBoxAs09.Name = "checkBoxAs09";
            this.checkBoxAs09.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs09.TabIndex = 13;
            this.checkBoxAs09.Text = "As09";
            this.checkBoxAs09.UseVisualStyleBackColor = true;
            this.checkBoxAs09.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs11
            // 
            this.checkBoxAs11.AutoSize = true;
            this.checkBoxAs11.Checked = true;
            this.checkBoxAs11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs11.Location = new System.Drawing.Point(766, 35);
            this.checkBoxAs11.Name = "checkBoxAs11";
            this.checkBoxAs11.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs11.TabIndex = 14;
            this.checkBoxAs11.Text = "As11";
            this.checkBoxAs11.UseVisualStyleBackColor = true;
            this.checkBoxAs11.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs12
            // 
            this.checkBoxAs12.AutoSize = true;
            this.checkBoxAs12.Checked = true;
            this.checkBoxAs12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs12.Location = new System.Drawing.Point(766, 63);
            this.checkBoxAs12.Name = "checkBoxAs12";
            this.checkBoxAs12.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs12.TabIndex = 15;
            this.checkBoxAs12.Text = "As12";
            this.checkBoxAs12.UseVisualStyleBackColor = true;
            this.checkBoxAs12.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs13
            // 
            this.checkBoxAs13.AutoSize = true;
            this.checkBoxAs13.Checked = true;
            this.checkBoxAs13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs13.Location = new System.Drawing.Point(766, 91);
            this.checkBoxAs13.Name = "checkBoxAs13";
            this.checkBoxAs13.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs13.TabIndex = 16;
            this.checkBoxAs13.Text = "As13";
            this.checkBoxAs13.UseVisualStyleBackColor = true;
            this.checkBoxAs13.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs14
            // 
            this.checkBoxAs14.AutoSize = true;
            this.checkBoxAs14.Checked = true;
            this.checkBoxAs14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs14.Location = new System.Drawing.Point(766, 119);
            this.checkBoxAs14.Name = "checkBoxAs14";
            this.checkBoxAs14.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs14.TabIndex = 17;
            this.checkBoxAs14.Text = "As14";
            this.checkBoxAs14.UseVisualStyleBackColor = true;
            this.checkBoxAs14.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs15
            // 
            this.checkBoxAs15.AutoSize = true;
            this.checkBoxAs15.Checked = true;
            this.checkBoxAs15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs15.Location = new System.Drawing.Point(766, 147);
            this.checkBoxAs15.Name = "checkBoxAs15";
            this.checkBoxAs15.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs15.TabIndex = 18;
            this.checkBoxAs15.Text = "As15";
            this.checkBoxAs15.UseVisualStyleBackColor = true;
            this.checkBoxAs15.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs21
            // 
            this.checkBoxAs21.AutoSize = true;
            this.checkBoxAs21.Checked = true;
            this.checkBoxAs21.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs21.Location = new System.Drawing.Point(842, 35);
            this.checkBoxAs21.Name = "checkBoxAs21";
            this.checkBoxAs21.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs21.TabIndex = 19;
            this.checkBoxAs21.Text = "As21";
            this.checkBoxAs21.UseVisualStyleBackColor = true;
            this.checkBoxAs21.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs22
            // 
            this.checkBoxAs22.AutoSize = true;
            this.checkBoxAs22.Checked = true;
            this.checkBoxAs22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs22.Location = new System.Drawing.Point(842, 63);
            this.checkBoxAs22.Name = "checkBoxAs22";
            this.checkBoxAs22.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs22.TabIndex = 20;
            this.checkBoxAs22.Text = "As22";
            this.checkBoxAs22.UseVisualStyleBackColor = true;
            this.checkBoxAs22.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs23
            // 
            this.checkBoxAs23.AutoSize = true;
            this.checkBoxAs23.Checked = true;
            this.checkBoxAs23.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs23.Location = new System.Drawing.Point(842, 91);
            this.checkBoxAs23.Name = "checkBoxAs23";
            this.checkBoxAs23.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs23.TabIndex = 21;
            this.checkBoxAs23.Text = "As23";
            this.checkBoxAs23.UseVisualStyleBackColor = true;
            this.checkBoxAs23.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs25
            // 
            this.checkBoxAs25.AutoSize = true;
            this.checkBoxAs25.Checked = true;
            this.checkBoxAs25.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAs25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs25.Location = new System.Drawing.Point(842, 147);
            this.checkBoxAs25.Name = "checkBoxAs25";
            this.checkBoxAs25.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs25.TabIndex = 22;
            this.checkBoxAs25.Text = "As25";
            this.checkBoxAs25.UseVisualStyleBackColor = true;
            this.checkBoxAs25.CheckedChanged += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(868, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ronald.majoor@tatasteeleurope.com";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 550);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 13);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/majoor404/Cgm23";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuweIndexMakenToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.quitToolStripMenuItem.Text = "Index";
            // 
            // nieuweIndexMakenToolStripMenuItem
            // 
            this.nieuweIndexMakenToolStripMenuItem.Name = "nieuweIndexMakenToolStripMenuItem";
            this.nieuweIndexMakenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nieuweIndexMakenToolStripMenuItem.Text = "Nieuwe Index Maken";
            this.nieuweIndexMakenToolStripMenuItem.Click += new System.EventHandler(this.NieuweIndexAsbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Aantal Charts :";
            // 
            // AantalCharts
            // 
            this.AantalCharts.AutoSize = true;
            this.AantalCharts.Location = new System.Drawing.Point(771, 221);
            this.AantalCharts.Name = "AantalCharts";
            this.AantalCharts.Size = new System.Drawing.Size(13, 13);
            this.AantalCharts.TabIndex = 29;
            this.AantalCharts.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filter op :";
            // 
            // FilterText
            // 
            this.FilterText.AutoSize = true;
            this.FilterText.Location = new System.Drawing.Point(676, 396);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(10, 13);
            this.FilterText.TabIndex = 28;
            this.FilterText.Text = ".";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 575);
            this.Controls.Add(this.AantalCharts);
            this.Controls.Add(this.FilterText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAs25);
            this.Controls.Add(this.checkBoxAs23);
            this.Controls.Add(this.checkBoxAs22);
            this.Controls.Add(this.checkBoxAs21);
            this.Controls.Add(this.checkBoxAs15);
            this.Controls.Add(this.checkBoxAs14);
            this.Controls.Add(this.checkBoxAs13);
            this.Controls.Add(this.checkBoxAs12);
            this.Controls.Add(this.checkBoxAs11);
            this.Controls.Add(this.checkBoxAs09);
            this.Controls.Add(this.checkBoxAs03);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxAs24);
            this.Controls.Add(this.checkBoxAs02);
            this.Controls.Add(this.checkBoxAs01);
            this.Controls.Add(this.DataText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charts CGM23";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DataText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox checkBoxAs01;
        private System.Windows.Forms.CheckBox checkBoxAs02;
        private System.Windows.Forms.CheckBox checkBoxAs24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.CheckBox checkBoxAs03;
        private System.Windows.Forms.CheckBox checkBoxAs09;
        private System.Windows.Forms.CheckBox checkBoxAs11;
        private System.Windows.Forms.CheckBox checkBoxAs12;
        private System.Windows.Forms.CheckBox checkBoxAs13;
        private System.Windows.Forms.CheckBox checkBoxAs14;
        private System.Windows.Forms.CheckBox checkBoxAs15;
        private System.Windows.Forms.CheckBox checkBoxAs21;
        private System.Windows.Forms.CheckBox checkBoxAs22;
        private System.Windows.Forms.CheckBox checkBoxAs23;
        private System.Windows.Forms.CheckBox checkBoxAs25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuweIndexMakenToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AantalCharts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FilterText;
    }
}

