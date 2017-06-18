using System.Drawing;

namespace Satan
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
            this.addButton = new System.Windows.Forms.Button();
            this.txtConcept = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.labelSummary = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.conceptHeaderLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelReview = new System.Windows.Forms.Panel();
            this.panelStartReview = new System.Windows.Forms.Panel();
            this.buttonGrade = new System.Windows.Forms.Button();
            this.panelGradeReview = new System.Windows.Forms.Panel();
            this.panelManual = new System.Windows.Forms.Panel();
            this.buttonManual = new System.Windows.Forms.Button();
            this.manualTextBox = new System.Windows.Forms.TextBox();
            this.fourthButton = new System.Windows.Forms.Button();
            this.thirdButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.conceptLabel = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMenu2 = new System.Windows.Forms.Button();
            this.buttonMenu1 = new System.Windows.Forms.Button();
            this.buttonMenuReview = new System.Windows.Forms.Button();
            this.buttonMenuAdd = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelAdd.SuspendLayout();
            this.panelReview.SuspendLayout();
            this.panelStartReview.SuspendLayout();
            this.panelGradeReview.SuspendLayout();
            this.panelManual.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(162, 236);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 20);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // txtConcept
            // 
            this.txtConcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcept.Location = new System.Drawing.Point(50, 30);
            this.txtConcept.Multiline = true;
            this.txtConcept.Name = "txtConcept";
            this.txtConcept.Size = new System.Drawing.Size(300, 49);
            this.txtConcept.TabIndex = 1;
            this.txtConcept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Concept:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "To Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.labelSummary);
            this.panelAdd.Controls.Add(this.txtSummary);
            this.panelAdd.Controls.Add(this.button1);
            this.panelAdd.Controls.Add(this.addButton);
            this.panelAdd.Controls.Add(this.txtConcept);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Location = new System.Drawing.Point(0, 5);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(400, 300);
            this.panelAdd.TabIndex = 4;
            this.panelAdd.Visible = false;
            this.panelAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelSummary
            // 
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Location = new System.Drawing.Point(133, 87);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(134, 18);
            this.labelSummary.TabIndex = 5;
            this.labelSummary.Text = "Summary:";
            this.labelSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSummary
            // 
            this.txtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummary.Location = new System.Drawing.Point(50, 112);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(300, 112);
            this.txtSummary.TabIndex = 2;
            this.txtSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // conceptHeaderLabel
            // 
            this.conceptHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conceptHeaderLabel.Location = new System.Drawing.Point(145, 5);
            this.conceptHeaderLabel.Name = "conceptHeaderLabel";
            this.conceptHeaderLabel.Size = new System.Drawing.Size(110, 18);
            this.conceptHeaderLabel.TabIndex = 2;
            this.conceptHeaderLabel.Text = "The Concept";
            this.conceptHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelReview
            // 
            this.panelReview.Controls.Add(this.panelGradeReview);
            this.panelReview.Controls.Add(this.panelStartReview);
            this.panelReview.Controls.Add(this.summaryLabel);
            this.panelReview.Controls.Add(this.conceptLabel);
            this.panelReview.Controls.Add(this.conceptHeaderLabel);
            this.panelReview.Location = new System.Drawing.Point(0, 0);
            this.panelReview.Name = "panelReview";
            this.panelReview.Size = new System.Drawing.Size(400, 300);
            this.panelReview.TabIndex = 4;
            this.panelReview.Visible = false;
            // 
            // panelStartReview
            // 
            this.panelStartReview.Controls.Add(this.buttonGrade);
            this.panelStartReview.Location = new System.Drawing.Point(0, 227);
            this.panelStartReview.Name = "panelStartReview";
            this.panelStartReview.Size = new System.Drawing.Size(400, 72);
            this.panelStartReview.TabIndex = 11;
            this.panelStartReview.Visible = false;
            // 
            // buttonGrade
            // 
            this.buttonGrade.Location = new System.Drawing.Point(129, 14);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(138, 47);
            this.buttonGrade.TabIndex = 0;
            this.buttonGrade.Text = "Grade";
            this.buttonGrade.UseVisualStyleBackColor = true;
            this.buttonGrade.Click += new System.EventHandler(this.buttonGrade_Click);
            // 
            // panelGradeReview
            // 
            this.panelGradeReview.Controls.Add(this.panelManual);
            this.panelGradeReview.Controls.Add(this.fourthButton);
            this.panelGradeReview.Controls.Add(this.thirdButton);
            this.panelGradeReview.Controls.Add(this.secondButton);
            this.panelGradeReview.Controls.Add(this.firstButton);
            this.panelGradeReview.Location = new System.Drawing.Point(0, 227);
            this.panelGradeReview.Name = "panelGradeReview";
            this.panelGradeReview.Size = new System.Drawing.Size(400, 72);
            this.panelGradeReview.TabIndex = 12;
            this.panelGradeReview.Visible = false;
            // 
            // panelManual
            // 
            this.panelManual.Controls.Add(this.buttonManual);
            this.panelManual.Controls.Add(this.manualTextBox);
            this.panelManual.Location = new System.Drawing.Point(125, 40);
            this.panelManual.Name = "panelManual";
            this.panelManual.Size = new System.Drawing.Size(170, 23);
            this.panelManual.TabIndex = 10;
            // 
            // buttonManual
            // 
            this.buttonManual.Location = new System.Drawing.Point(80, 0);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(75, 23);
            this.buttonManual.TabIndex = 6;
            this.buttonManual.Text = "Manual";
            this.buttonManual.UseVisualStyleBackColor = true;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // manualTextBox
            // 
            this.manualTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.manualTextBox.Location = new System.Drawing.Point(0, 0);
            this.manualTextBox.Name = "manualTextBox";
            this.manualTextBox.Size = new System.Drawing.Size(70, 23);
            this.manualTextBox.TabIndex = 5;
            this.manualTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fourthButton
            // 
            this.fourthButton.Location = new System.Drawing.Point(310, 10);
            this.fourthButton.Name = "fourthButton";
            this.fourthButton.Size = new System.Drawing.Size(80, 23);
            this.fourthButton.TabIndex = 4;
            this.fourthButton.Text = "Excellent";
            this.fourthButton.UseVisualStyleBackColor = true;
            this.fourthButton.Click += new System.EventHandler(this.fourthButton_Click);
            // 
            // thirdButton
            // 
            this.thirdButton.Location = new System.Drawing.Point(210, 10);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(80, 23);
            this.thirdButton.TabIndex = 3;
            this.thirdButton.Text = "Good";
            this.thirdButton.UseVisualStyleBackColor = true;
            this.thirdButton.Click += new System.EventHandler(this.thirdButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(110, 10);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(80, 23);
            this.secondButton.TabIndex = 2;
            this.secondButton.Text = "Average";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(10, 10);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(80, 23);
            this.firstButton.TabIndex = 1;
            this.firstButton.Text = "Bad";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabel.Location = new System.Drawing.Point(50, 62);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(300, 150);
            this.summaryLabel.TabIndex = 4;
            this.summaryLabel.Text = "summary";
            this.summaryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conceptLabel
            // 
            this.conceptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conceptLabel.Location = new System.Drawing.Point(50, 31);
            this.conceptLabel.Name = "conceptLabel";
            this.conceptLabel.Size = new System.Drawing.Size(300, 18);
            this.conceptLabel.TabIndex = 3;
            this.conceptLabel.Text = "concept";
            this.conceptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonMenu2);
            this.panelMenu.Controls.Add(this.buttonMenu1);
            this.panelMenu.Controls.Add(this.buttonMenuReview);
            this.panelMenu.Controls.Add(this.buttonMenuAdd);
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(400, 300);
            this.panelMenu.TabIndex = 11;
            this.panelMenu.Visible = false;
            // 
            // buttonMenu2
            // 
            this.buttonMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMenu2.Location = new System.Drawing.Point(100, 230);
            this.buttonMenu2.Name = "buttonMenu2";
            this.buttonMenu2.Size = new System.Drawing.Size(200, 35);
            this.buttonMenu2.TabIndex = 4;
            this.buttonMenu2.Text = "???";
            this.buttonMenu2.UseVisualStyleBackColor = true;
            // 
            // buttonMenu1
            // 
            this.buttonMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMenu1.Location = new System.Drawing.Point(100, 180);
            this.buttonMenu1.Name = "buttonMenu1";
            this.buttonMenu1.Size = new System.Drawing.Size(200, 35);
            this.buttonMenu1.TabIndex = 3;
            this.buttonMenu1.Text = "???";
            this.buttonMenu1.UseVisualStyleBackColor = true;
            // 
            // buttonMenuReview
            // 
            this.buttonMenuReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMenuReview.Location = new System.Drawing.Point(100, 130);
            this.buttonMenuReview.Name = "buttonMenuReview";
            this.buttonMenuReview.Size = new System.Drawing.Size(200, 35);
            this.buttonMenuReview.TabIndex = 2;
            this.buttonMenuReview.Text = "Review";
            this.buttonMenuReview.UseVisualStyleBackColor = true;
            this.buttonMenuReview.Click += new System.EventHandler(this.buttonMenuReview_Click);
            // 
            // buttonMenuAdd
            // 
            this.buttonMenuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMenuAdd.Location = new System.Drawing.Point(100, 80);
            this.buttonMenuAdd.Name = "buttonMenuAdd";
            this.buttonMenuAdd.Size = new System.Drawing.Size(200, 35);
            this.buttonMenuAdd.TabIndex = 1;
            this.buttonMenuAdd.Text = "Add";
            this.buttonMenuAdd.UseVisualStyleBackColor = true;
            this.buttonMenuAdd.Click += new System.EventHandler(this.buttonMenuAdd_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelMenu.Location = new System.Drawing.Point(150, 20);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(100, 50);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "MENU";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.panelReview);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelAdd);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Concepts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelReview.ResumeLayout(false);
            this.panelStartReview.ResumeLayout(false);
            this.panelGradeReview.ResumeLayout(false);
            this.panelManual.ResumeLayout(false);
            this.panelManual.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox txtConcept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelReview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label conceptHeaderLabel;
        private System.Windows.Forms.Label conceptLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button fourthButton;
        private System.Windows.Forms.Button thirdButton;
        private System.Windows.Forms.TextBox manualTextBox;
        private System.Windows.Forms.Panel panelManual;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonMenuAdd;
        private System.Windows.Forms.Button buttonMenuReview;
        private System.Windows.Forms.Button buttonMenu2;
        private System.Windows.Forms.Button buttonMenu1;
        private System.Windows.Forms.Panel panelStartReview;
        private System.Windows.Forms.Panel panelGradeReview;
        private System.Windows.Forms.Button buttonGrade;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox txtSummary;
    }
}

