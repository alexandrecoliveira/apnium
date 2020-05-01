namespace APNIUM
{
    partial class Form1
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
            this.frmDataInicio = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.frmDataFim = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScrap = new System.Windows.Forms.Button();
            this.lblDtInicioTeste = new System.Windows.Forms.Label();
            this.lblDtFimTeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmDataInicio
            // 
            this.frmDataInicio.Location = new System.Drawing.Point(33, 45);
            this.frmDataInicio.Name = "frmDataInicio";
            this.frmDataInicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "INÍCIO";
            // 
            // frmDataFim
            // 
            this.frmDataFim.Location = new System.Drawing.Point(288, 45);
            this.frmDataFim.Name = "frmDataFim";
            this.frmDataFim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "FIM";
            // 
            // btnScrap
            // 
            this.btnScrap.Location = new System.Drawing.Point(40, 234);
            this.btnScrap.Name = "btnScrap";
            this.btnScrap.Size = new System.Drawing.Size(219, 39);
            this.btnScrap.TabIndex = 4;
            this.btnScrap.Text = "SCRAP";
            this.btnScrap.UseVisualStyleBackColor = true;
            this.btnScrap.Click += new System.EventHandler(this.btnScrap_Click);
            // 
            // lblDtInicioTeste
            // 
            this.lblDtInicioTeste.AutoSize = true;
            this.lblDtInicioTeste.Location = new System.Drawing.Point(293, 236);
            this.lblDtInicioTeste.Name = "lblDtInicioTeste";
            this.lblDtInicioTeste.Size = new System.Drawing.Size(80, 13);
            this.lblDtInicioTeste.TabIndex = 5;
            this.lblDtInicioTeste.Text = "lblDtInicioTeste";
            // 
            // lblDtFimTeste
            // 
            this.lblDtFimTeste.AutoSize = true;
            this.lblDtFimTeste.Location = new System.Drawing.Point(293, 302);
            this.lblDtFimTeste.Name = "lblDtFimTeste";
            this.lblDtFimTeste.Size = new System.Drawing.Size(71, 13);
            this.lblDtFimTeste.TabIndex = 6;
            this.lblDtFimTeste.Text = "lblDtFimTeste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.lblDtFimTeste);
            this.Controls.Add(this.lblDtInicioTeste);
            this.Controls.Add(this.btnScrap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frmDataFim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmDataInicio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APINFO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar frmDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar frmDataFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScrap;
        private System.Windows.Forms.Label lblDtInicioTeste;
        private System.Windows.Forms.Label lblDtFimTeste;
    }
}

