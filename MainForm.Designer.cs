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
            this.DataText = new System.Windows.Forms.TextBox();
            this.NieuweIndexAsbutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxAs01 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs02 = new System.Windows.Forms.CheckBox();
            this.checkBoxAs24 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.SelectGeen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataText
            // 
            this.DataText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataText.Location = new System.Drawing.Point(12, 12);
            this.DataText.Multiline = true;
            this.DataText.Name = "DataText";
            this.DataText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DataText.Size = new System.Drawing.Size(635, 551);
            this.DataText.TabIndex = 1;
            // 
            // NieuweIndexAsbutton
            // 
            this.NieuweIndexAsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NieuweIndexAsbutton.Location = new System.Drawing.Point(802, 362);
            this.NieuweIndexAsbutton.Name = "NieuweIndexAsbutton";
            this.NieuweIndexAsbutton.Size = new System.Drawing.Size(243, 38);
            this.NieuweIndexAsbutton.TabIndex = 2;
            this.NieuweIndexAsbutton.Text = "Maak nieuwe index van een AS";
            this.NieuweIndexAsbutton.UseVisualStyleBackColor = true;
            this.NieuweIndexAsbutton.Click += new System.EventHandler(this.NieuweIndexAsbutton_Click);
            // 
            // checkBoxAs01
            // 
            this.checkBoxAs01.AutoSize = true;
            this.checkBoxAs01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs01.Location = new System.Drawing.Point(679, 16);
            this.checkBoxAs01.Name = "checkBoxAs01";
            this.checkBoxAs01.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs01.TabIndex = 3;
            this.checkBoxAs01.Text = "As01";
            this.checkBoxAs01.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs02
            // 
            this.checkBoxAs02.AutoSize = true;
            this.checkBoxAs02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs02.Location = new System.Drawing.Point(679, 44);
            this.checkBoxAs02.Name = "checkBoxAs02";
            this.checkBoxAs02.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs02.TabIndex = 4;
            this.checkBoxAs02.Text = "As02";
            this.checkBoxAs02.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs24
            // 
            this.checkBoxAs24.AutoSize = true;
            this.checkBoxAs24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs24.Location = new System.Drawing.Point(679, 352);
            this.checkBoxAs24.Name = "checkBoxAs24";
            this.checkBoxAs24.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs24.TabIndex = 5;
            this.checkBoxAs24.Text = "As24";
            this.checkBoxAs24.UseVisualStyleBackColor = true;
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
            // SelectAll
            // 
            this.SelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAll.Location = new System.Drawing.Point(802, 12);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(113, 38);
            this.SelectAll.TabIndex = 10;
            this.SelectAll.Text = "Selecteer Alles";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(802, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "Laad Tags van geselecteerde As-en";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.HerschrijfTextVeld);
            // 
            // checkBoxAs03
            // 
            this.checkBoxAs03.AutoSize = true;
            this.checkBoxAs03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs03.Location = new System.Drawing.Point(679, 72);
            this.checkBoxAs03.Name = "checkBoxAs03";
            this.checkBoxAs03.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs03.TabIndex = 12;
            this.checkBoxAs03.Text = "As03";
            this.checkBoxAs03.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs09
            // 
            this.checkBoxAs09.AutoSize = true;
            this.checkBoxAs09.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs09.Location = new System.Drawing.Point(679, 100);
            this.checkBoxAs09.Name = "checkBoxAs09";
            this.checkBoxAs09.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs09.TabIndex = 13;
            this.checkBoxAs09.Text = "As09";
            this.checkBoxAs09.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs11
            // 
            this.checkBoxAs11.AutoSize = true;
            this.checkBoxAs11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs11.Location = new System.Drawing.Point(679, 128);
            this.checkBoxAs11.Name = "checkBoxAs11";
            this.checkBoxAs11.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs11.TabIndex = 14;
            this.checkBoxAs11.Text = "As11";
            this.checkBoxAs11.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs12
            // 
            this.checkBoxAs12.AutoSize = true;
            this.checkBoxAs12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs12.Location = new System.Drawing.Point(679, 156);
            this.checkBoxAs12.Name = "checkBoxAs12";
            this.checkBoxAs12.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs12.TabIndex = 15;
            this.checkBoxAs12.Text = "As12";
            this.checkBoxAs12.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs13
            // 
            this.checkBoxAs13.AutoSize = true;
            this.checkBoxAs13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs13.Location = new System.Drawing.Point(679, 184);
            this.checkBoxAs13.Name = "checkBoxAs13";
            this.checkBoxAs13.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs13.TabIndex = 16;
            this.checkBoxAs13.Text = "As13";
            this.checkBoxAs13.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs14
            // 
            this.checkBoxAs14.AutoSize = true;
            this.checkBoxAs14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs14.Location = new System.Drawing.Point(679, 212);
            this.checkBoxAs14.Name = "checkBoxAs14";
            this.checkBoxAs14.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs14.TabIndex = 17;
            this.checkBoxAs14.Text = "As14";
            this.checkBoxAs14.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs15
            // 
            this.checkBoxAs15.AutoSize = true;
            this.checkBoxAs15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs15.Location = new System.Drawing.Point(679, 240);
            this.checkBoxAs15.Name = "checkBoxAs15";
            this.checkBoxAs15.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs15.TabIndex = 18;
            this.checkBoxAs15.Text = "As15";
            this.checkBoxAs15.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs21
            // 
            this.checkBoxAs21.AutoSize = true;
            this.checkBoxAs21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs21.Location = new System.Drawing.Point(679, 268);
            this.checkBoxAs21.Name = "checkBoxAs21";
            this.checkBoxAs21.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs21.TabIndex = 19;
            this.checkBoxAs21.Text = "As21";
            this.checkBoxAs21.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs22
            // 
            this.checkBoxAs22.AutoSize = true;
            this.checkBoxAs22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs22.Location = new System.Drawing.Point(679, 296);
            this.checkBoxAs22.Name = "checkBoxAs22";
            this.checkBoxAs22.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs22.TabIndex = 20;
            this.checkBoxAs22.Text = "As22";
            this.checkBoxAs22.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs23
            // 
            this.checkBoxAs23.AutoSize = true;
            this.checkBoxAs23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs23.Location = new System.Drawing.Point(679, 324);
            this.checkBoxAs23.Name = "checkBoxAs23";
            this.checkBoxAs23.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs23.TabIndex = 21;
            this.checkBoxAs23.Text = "As23";
            this.checkBoxAs23.UseVisualStyleBackColor = true;
            // 
            // checkBoxAs25
            // 
            this.checkBoxAs25.AutoSize = true;
            this.checkBoxAs25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAs25.Location = new System.Drawing.Point(679, 380);
            this.checkBoxAs25.Name = "checkBoxAs25";
            this.checkBoxAs25.Size = new System.Drawing.Size(56, 20);
            this.checkBoxAs25.TabIndex = 22;
            this.checkBoxAs25.Text = "As25";
            this.checkBoxAs25.UseVisualStyleBackColor = true;
            // 
            // SelectGeen
            // 
            this.SelectGeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectGeen.Location = new System.Drawing.Point(932, 12);
            this.SelectGeen.Name = "SelectGeen";
            this.SelectGeen.Size = new System.Drawing.Size(113, 38);
            this.SelectGeen.TabIndex = 23;
            this.SelectGeen.Text = "Selecteer Geen";
            this.SelectGeen.UseVisualStyleBackColor = true;
            this.SelectGeen.Click += new System.EventHandler(this.SelectGeen_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectGeen);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxAs24);
            this.Controls.Add(this.checkBoxAs02);
            this.Controls.Add(this.checkBoxAs01);
            this.Controls.Add(this.NieuweIndexAsbutton);
            this.Controls.Add(this.DataText);
            this.Name = "MainForm";
            this.Text = "Tags CGM23";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DataText;
        private System.Windows.Forms.Button NieuweIndexAsbutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox checkBoxAs01;
        private System.Windows.Forms.CheckBox checkBoxAs02;
        private System.Windows.Forms.CheckBox checkBoxAs24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Button SelectGeen;
        private System.Windows.Forms.Label label1;
    }
}

