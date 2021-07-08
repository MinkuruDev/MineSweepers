
namespace MineSweeper
{
    partial class frmMain
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblMine = new System.Windows.Forms.Label();
            this.txtMines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(201, 45);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(119, 41);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblMine
            // 
            this.lblMine.AutoSize = true;
            this.lblMine.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMine.Location = new System.Drawing.Point(12, 12);
            this.lblMine.Name = "lblMine";
            this.lblMine.Size = new System.Drawing.Size(65, 28);
            this.lblMine.TabIndex = 1;
            this.lblMine.Text = "Mine: ";
            this.lblMine.Click += new System.EventHandler(this.lblMine_Click);
            // 
            // txtMines
            // 
            this.txtMines.Location = new System.Drawing.Point(69, 12);
            this.txtMines.Name = "txtMines";
            this.txtMines.Size = new System.Drawing.Size(57, 27);
            this.txtMines.TabIndex = 2;
            this.txtMines.Text = "15";
            this.txtMines.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rows:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(319, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columns";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(224, 12);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(57, 27);
            this.txtRows.TabIndex = 5;
            this.txtRows.Text = "15";
            this.txtRows.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(413, 12);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(57, 27);
            this.txtCols.TabIndex = 6;
            this.txtCols.Text = "10";
            this.txtCols.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 583);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMines);
            this.Controls.Add(this.lblMine);
            this.Controls.Add(this.btnStartGame);
            this.Name = "frmMain";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblMine;
        private System.Windows.Forms.TextBox txtMines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
    }
}

