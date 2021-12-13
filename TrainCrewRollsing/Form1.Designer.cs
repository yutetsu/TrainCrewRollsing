
namespace TrainCrewRollsing
{
    partial class FormRollsing
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupRollsing = new System.Windows.Forms.GroupBox();
            this.buttonRollsingTest = new System.Windows.Forms.Button();
            this.buttonRollsingSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRollsingIP = new System.Windows.Forms.TextBox();
            this.pictureRollsing = new System.Windows.Forms.PictureBox();
            this.groupTrain = new System.Windows.Forms.GroupBox();
            this.comboTrainSeries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupRollsing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRollsing)).BeginInit();
            this.groupTrain.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRollsing
            // 
            this.groupRollsing.Controls.Add(this.buttonRollsingTest);
            this.groupRollsing.Controls.Add(this.buttonRollsingSave);
            this.groupRollsing.Controls.Add(this.label1);
            this.groupRollsing.Controls.Add(this.textBoxRollsingIP);
            this.groupRollsing.Location = new System.Drawing.Point(13, 13);
            this.groupRollsing.Name = "groupRollsing";
            this.groupRollsing.Size = new System.Drawing.Size(459, 103);
            this.groupRollsing.TabIndex = 0;
            this.groupRollsing.TabStop = false;
            this.groupRollsing.Text = "Rollsing Settings";
            // 
            // buttonRollsingTest
            // 
            this.buttonRollsingTest.Location = new System.Drawing.Point(6, 70);
            this.buttonRollsingTest.Name = "buttonRollsingTest";
            this.buttonRollsingTest.Size = new System.Drawing.Size(75, 23);
            this.buttonRollsingTest.TabIndex = 3;
            this.buttonRollsingTest.Text = "Test";
            this.buttonRollsingTest.UseVisualStyleBackColor = true;
            this.buttonRollsingTest.Click += new System.EventHandler(this.buttonRollsingTest_Click);
            // 
            // buttonRollsingSave
            // 
            this.buttonRollsingSave.Location = new System.Drawing.Point(378, 70);
            this.buttonRollsingSave.Name = "buttonRollsingSave";
            this.buttonRollsingSave.Size = new System.Drawing.Size(75, 23);
            this.buttonRollsingSave.TabIndex = 2;
            this.buttonRollsingSave.Text = "Save";
            this.buttonRollsingSave.UseVisualStyleBackColor = true;
            this.buttonRollsingSave.Click += new System.EventHandler(this.buttonRollsingSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rollsing IP/Domain name :";
            // 
            // textBoxRollsingIP
            // 
            this.textBoxRollsingIP.Location = new System.Drawing.Point(143, 35);
            this.textBoxRollsingIP.Name = "textBoxRollsingIP";
            this.textBoxRollsingIP.Size = new System.Drawing.Size(310, 20);
            this.textBoxRollsingIP.TabIndex = 0;
            // 
            // pictureRollsing
            // 
            this.pictureRollsing.InitialImage = null;
            this.pictureRollsing.Location = new System.Drawing.Point(32, 31);
            this.pictureRollsing.Name = "pictureRollsing";
            this.pictureRollsing.Size = new System.Drawing.Size(144, 32);
            this.pictureRollsing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRollsing.TabIndex = 3;
            this.pictureRollsing.TabStop = false;
            // 
            // groupTrain
            // 
            this.groupTrain.Controls.Add(this.comboTrainSeries);
            this.groupTrain.Controls.Add(this.label2);
            this.groupTrain.Location = new System.Drawing.Point(13, 122);
            this.groupTrain.Name = "groupTrain";
            this.groupTrain.Size = new System.Drawing.Size(245, 83);
            this.groupTrain.TabIndex = 1;
            this.groupTrain.TabStop = false;
            this.groupTrain.Text = "TrainSelection";
            // 
            // comboTrainSeries
            // 
            this.comboTrainSeries.AllowDrop = true;
            this.comboTrainSeries.FormattingEnabled = true;
            this.comboTrainSeries.Items.AddRange(new object[] {
            "TH5320"});
            this.comboTrainSeries.Location = new System.Drawing.Point(118, 35);
            this.comboTrainSeries.Name = "comboTrainSeries";
            this.comboTrainSeries.Size = new System.Drawing.Size(121, 21);
            this.comboTrainSeries.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Train series selection";
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.pictureRollsing);
            this.groupOutput.Location = new System.Drawing.Point(264, 122);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(208, 83);
            this.groupOutput.TabIndex = 2;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Output";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRollsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupTrain);
            this.Controls.Add(this.groupRollsing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRollsing";
            this.Text = "Rollsign Controller";
            this.groupRollsing.ResumeLayout(false);
            this.groupRollsing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRollsing)).EndInit();
            this.groupTrain.ResumeLayout(false);
            this.groupTrain.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupRollsing;
        private System.Windows.Forms.GroupBox groupTrain;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.Button buttonRollsingTest;
        private System.Windows.Forms.Button buttonRollsingSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRollsingIP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTrainSeries;
        private System.Windows.Forms.PictureBox pictureRollsing;
    }
}

