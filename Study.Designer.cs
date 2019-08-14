namespace University
{
    partial class Study
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
            this.teacher_combo = new System.Windows.Forms.ComboBox();
            this.thing_combo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_audition = new System.Windows.Forms.TextBox();
            this.num_group = new System.Windows.Forms.TextBox();
            this.save_study = new System.Windows.Forms.Button();
            this.back_study = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacher_combo
            // 
            this.teacher_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacher_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_combo.FormattingEnabled = true;
            this.teacher_combo.Location = new System.Drawing.Point(12, 13);
            this.teacher_combo.Name = "teacher_combo";
            this.teacher_combo.Size = new System.Drawing.Size(641, 33);
            this.teacher_combo.TabIndex = 0;
            // 
            // thing_combo
            // 
            this.thing_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thing_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thing_combo.FormattingEnabled = true;
            this.thing_combo.Location = new System.Drawing.Point(12, 52);
            this.thing_combo.Name = "thing_combo";
            this.thing_combo.Size = new System.Drawing.Size(641, 33);
            this.thing_combo.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 91);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 10, 24, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 10, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 29);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2018, 10, 23, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время начала пары:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(249, 126);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(55, 29);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(335, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер аудитории:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(335, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер группы:";
            // 
            // num_audition
            // 
            this.num_audition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_audition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_audition.Location = new System.Drawing.Point(553, 91);
            this.num_audition.Name = "num_audition";
            this.num_audition.Size = new System.Drawing.Size(100, 29);
            this.num_audition.TabIndex = 9;
            // 
            // num_group
            // 
            this.num_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_group.Location = new System.Drawing.Point(553, 126);
            this.num_group.Name = "num_group";
            this.num_group.Size = new System.Drawing.Size(100, 29);
            this.num_group.TabIndex = 10;
            // 
            // save_study
            // 
            this.save_study.BackColor = System.Drawing.Color.PowderBlue;
            this.save_study.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_study.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_study.Location = new System.Drawing.Point(12, 161);
            this.save_study.Name = "save_study";
            this.save_study.Size = new System.Drawing.Size(641, 35);
            this.save_study.TabIndex = 11;
            this.save_study.Text = "Сохранить";
            this.save_study.UseVisualStyleBackColor = false;
            this.save_study.Click += new System.EventHandler(this.save_study_Click);
            // 
            // back_study
            // 
            this.back_study.BackColor = System.Drawing.Color.PowderBlue;
            this.back_study.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_study.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_study.Location = new System.Drawing.Point(564, 202);
            this.back_study.Name = "back_study";
            this.back_study.Size = new System.Drawing.Size(90, 33);
            this.back_study.TabIndex = 12;
            this.back_study.Text = "Назад";
            this.back_study.UseVisualStyleBackColor = false;
            this.back_study.Click += new System.EventHandler(this.back_study_Click);
            // 
            // Study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(665, 240);
            this.ControlBox = false;
            this.Controls.Add(this.back_study);
            this.Controls.Add(this.save_study);
            this.Controls.Add(this.num_group);
            this.Controls.Add(this.num_audition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.thing_combo);
            this.Controls.Add(this.teacher_combo);
            this.Name = "Study";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебная пара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teacher_combo;
        private System.Windows.Forms.ComboBox thing_combo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_audition;
        private System.Windows.Forms.TextBox num_group;
        private System.Windows.Forms.Button save_study;
        private System.Windows.Forms.Button back_study;
    }
}