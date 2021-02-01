
namespace FormsGraphics
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
            this.EntryPanel = new System.Windows.Forms.Panel();
            this.go_button = new System.Windows.Forms.Button();
            this.increment = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.line_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.Panel();
            this.EntryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntryPanel
            // 
            this.EntryPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EntryPanel.Controls.Add(this.go_button);
            this.EntryPanel.Controls.Add(this.increment);
            this.EntryPanel.Controls.Add(this.length);
            this.EntryPanel.Controls.Add(this.angle);
            this.EntryPanel.Controls.Add(this.line_number);
            this.EntryPanel.Controls.Add(this.label4);
            this.EntryPanel.Controls.Add(this.label3);
            this.EntryPanel.Controls.Add(this.label2);
            this.EntryPanel.Controls.Add(this.label1);
            this.EntryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EntryPanel.Location = new System.Drawing.Point(583, 0);
            this.EntryPanel.Name = "EntryPanel";
            this.EntryPanel.Size = new System.Drawing.Size(217, 450);
            this.EntryPanel.TabIndex = 0;
            // 
            // go_button
            // 
            this.go_button.Font = new System.Drawing.Font("OpenSymbol", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_button.Location = new System.Drawing.Point(34, 226);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(145, 82);
            this.go_button.TabIndex = 8;
            this.go_button.Text = "GO!";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.Render);
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(91, 95);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(100, 20);
            this.increment.TabIndex = 7;
            this.increment.Text = "1";
            this.increment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(91, 69);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 20);
            this.length.TabIndex = 6;
            this.length.Text = "100";
            this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(91, 43);
            this.angle.Name = "angle";
            this.angle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.angle.Size = new System.Drawing.Size(100, 20);
            this.angle.TabIndex = 5;
            this.angle.Text = "90";
            this.angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // line_number
            // 
            this.line_number.Location = new System.Drawing.Point(91, 17);
            this.line_number.Name = "line_number";
            this.line_number.Size = new System.Drawing.Size(100, 20);
            this.line_number.TabIndex = 4;
            this.line_number.Text = "200";
            this.line_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Increment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Lines";
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(583, 450);
            this.Canvas.TabIndex = 1;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.EntryPanel);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics";
            this.EntryPanel.ResumeLayout(false);
            this.EntryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EntryPanel;
        private System.Windows.Forms.TextBox increment;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.TextBox line_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button go_button;
    }
}

